# 🚀 Start: Request for DB Connection

- Triggered from application layer (e.g., Controller, Service)
- Often needed by repository to execute SQL or EF raw queries
- Dependency Injection resolves `IConnectionFactory`

```csharp
// Example: Triggering DB connection
var connection = _connectionFactory.CreateConnection();
using (var command = connection.CreateCommand())
{
    command.CommandText = "SELECT * FROM Users";
    var reader = command.ExecuteReader();
}
```

---

## 🔁 Resolve IConnectionFactory

- Registered in DI container, typically as 🧱 Singleton
- Concrete implementation: `DbConnectionFactory`
- Constructor-injected dependencies:
  - 🌐 `IHttpContextAccessor`: Access request context for tenant ID
  - ⚙️ `ConnectionSettings`: Reads default connection info
  - 🧩 `IAppClientConfig`: Logic to load tenant/client config

```csharp
// Example: Resolving IConnectionFactory
services.AddSingleton<IConnectionFactory, DbConnectionFactory>();
```

---

## ⚙️ DbConnectionFactory Initialization

- 🔍 Check: Is `DefaultConnectionName` non-empty?
- 📂 Read from `appsettings.json` or external config provider
- 🧪 Validate `HttpContext` if multi-tenancy is active
- 🧠 Cache/memoize static factory data if possible (perf boost)

```csharp
// Example: DbConnectionFactory initialization
public DbConnectionFactory(IHttpContextAccessor httpContextAccessor, 
                           ConnectionSettings settings, 
                           IAppClientConfig clientConfig)
{
    _httpContextAccessor = httpContextAccessor;
    _settings = settings;
    _clientConfig = clientConfig;
}
```

---

## 🌐 Multi-Tenancy Handling (Optional)

- Condition: `EnableMultiTenancy == true` in ⚙️ settings
- Extract tenant ID from:
  - 📬 `Headers["X-Tenant-ID"]`
  - 🔄 Fallback to query string or default
- Call: `AppClientConfig.GetClient(tenantId)`

```csharp
// Example: Multi-tenancy handling
var tenantId = httpContext.Request.Headers["X-Tenant-ID"];
var clientConfig = _clientConfig.GetClient(tenantId);
```

---

## 🧪 Build Connection String

- 🧱 Use `DbConnectionStringBuilder` for specific provider
- Load 🔧 base connection string from config
- 🔄 Override with tenant details (if multi-tenant)

```csharp
// Example: Building connection string
var builder = new SqlConnectionStringBuilder(baseConnectionString)
{
    DataSource = clientConfig.Server,
    InitialCatalog = clientConfig.Database,
    UserID = clientConfig.User,
    Password = clientConfig.Password
};
var finalConnectionString = builder.ConnectionString;
```

---

## 🛠️ Create Database Connection

- Factory: 🏭 `DbProviderFactory.CreateConnection()`
- Providers: 🧪 `SqlClient`, 🐘 `Npgsql`, 🦠 `MySqlConnector`
- Set: `conn.ConnectionString = finalConnStr`

```csharp
// Example: Creating database connection
var connection = DbProviderFactories.GetFactory("System.Data.SqlClient").CreateConnection();
connection.ConnectionString = finalConnectionString;
connection.Open();
```

---

## ✅ Return Open IDbConnection

- 📦 Return usable `IDbConnection` object
- 🧵 Used in repository or service layer

```csharp
// Example: Returning IDbConnection
return connection;
```
