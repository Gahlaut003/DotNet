using Microsoft.Extensions.Options;
using System.Configuration;
using System.Data.Common;
using System.Data;
using Utility_001.Libs.DAL;
using Utility_001.Libs.Entities;
using Utility_001.Libs.SharedKernel;
using System.Data;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;


namespace Utility_001.Libs.DAL
{
    public class DbConnectionFactory : IConnectionFactory
    {
        protected readonly HttpContext httpContext;
        protected readonly ConnectionSettings connectionSettings;
        protected readonly IOptions<AppClientConfig> clientConfigOptions;
        private DbProviderFactory _provider;
        private readonly string _connectionString;
        public bool IsMultiTenant { get; private set; }
        public string ClientDatabase { get; private set; }
        private string _name;
        protected const string TenantIdFieldName = DefaultConstants.ClientGuidField;
        protected const string DatabaseFieldKeyword = DefaultConstants.Database;
        protected const string ServerFieldKeyword = DefaultConstants.Server;
        protected const string UserIdFieldKeyword = DefaultConstants.Uid;
        protected const string PasswordFieldKeyword = DefaultConstants.Pwd;

     
    /*    public DbConnectionFactory(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }*/
        [ActivatorUtilitiesConstructor]
        public DbConnectionFactory(HttpContext httpContext, ConnectionSettings connectionSetting)
        {
            this.httpContext = httpContext;

            this.connectionSettings = connectionSetting;
            var dbConnectionStringBuilder = GetConnectionStringBuilder();
            _connectionString = dbConnectionStringBuilder.ConnectionString;

            _provider = DataAccessProviderHelper.GetDbProviderFactory(connectionSetting.DatabaseType);
            _name = connectionSetting.DatabaseType.ToString(); // conStr.ProviderName;

            IsMultiTenant = false;
            ClientDatabase = GetDefaultDatabase();
        }
        public DbConnectionFactory(IHttpContextAccessor httpContentAccessor, IOptions<ConnectionSettings> connectionOptions, IOptions<AppClientConfig> clientConfigOptions)
        {
            if (httpContentAccessor != null)
                this.httpContext = httpContentAccessor.HttpContext;
            string connectionName;
            connectionName = this.httpContext.Request.Headers[TenantIdFieldName].ToString();
            this.connectionSettings = connectionOptions.Value;
            this.connectionSettings = connectionOptions.Value;
            this.clientConfigOptions = clientConfigOptions;
            IsMultiTenant = connectionOptions.Value.MultiTenant == 1;
            var conStr = connectionOptions.Value.DefaultConnection; //ConfigurationManager.ConnectionStrings[connectionName];
            if (conStr == null)
                //throw new ConfigurationErrorsException(string.Format("Failed to find connection string named '{0}' in app/web.config.", connectionName));
                throw new Exception(string.Format("Failed to find connection string named '{0}' in app/web.config.", "DefaultConnection"));

            var dbConnectionStringBuilder = GetConnectionStringBuilder();
            _connectionString = dbConnectionStringBuilder.ConnectionString;
            _provider = DataAccessProviderHelper.GetDbProviderFactory(connectionOptions.Value.DatabaseType);
            if (IsMultiTenant && clientConfigOptions.Value != null)
            {
                try
                {
                    ClientDatabase = GetDatabaseNameForTenantID(connectionName);
                }
                catch (System.Exception)
                {


                }

            }
        }

        public IDbConnection Create()
        {
            return new MySqlConnection(_connectionString); // Or MySqlConnection if using MySQL
        }
        protected virtual void ValidateDefaultConnection()
        {
            if (string.IsNullOrEmpty(this.connectionSettings.DefaultConnection))
            {
                throw new ArgumentNullException(nameof(this.connectionSettings.DefaultConnection));
            }
        }
        protected virtual void ValidateHttpContext()
        {
            if (this.httpContext == null)
            {
                throw new ArgumentNullException(nameof(this.httpContext));
            }
        }
        protected DbConnectionStringBuilder GetConnectionStringBuilder()
        {
            ValidateDefaultConnection();

            var connectionBuilder = DbConnectionBuilderHelper.GetConnectionBuilder(connectionSettings);
            var connectionStringBuilder = connectionBuilder.GetConnectionStringBuilder(connectionSettings.DefaultConnection);
            return connectionStringBuilder;
        }
        private string GetDefaultDatabase()
        {

            var connectionStringBuilder = GetConnectionStringBuilder();
            object dbName;
            if (connectionStringBuilder.TryGetValue(DatabaseFieldKeyword, out dbName))
                return dbName?.ToString();
            else
                return string.Empty;

        }
        protected string GetClientConnectionString(string connectionName)
        {
            ValidateDefaultConnection();
            if (connectionName == null) throw new ArgumentNullException("connectionName");
            var connectionStringBuilder = GetConnectionStringBuilder();

            // 1. Create Connection String Builder using Default connection string
            //var connectionBuilder = databaseType.GetConnectionBuilder (connectionOptions.Value.DefaultConnection);

            // 2. Remove old Database Name from connection string
            connectionStringBuilder.Remove(DatabaseFieldKeyword);
            connectionStringBuilder.Remove(ServerFieldKeyword);
            connectionStringBuilder.Remove(UserIdFieldKeyword);
            connectionStringBuilder.Remove(PasswordFieldKeyword);
            connectionStringBuilder.Add(ServerFieldKeyword, GetDatabaseNameForTenantID(connectionName, ServerFieldKeyword));
            connectionStringBuilder.Add(DatabaseFieldKeyword, GetDatabaseNameForTenantID(connectionName, DatabaseFieldKeyword));
            connectionStringBuilder.Add(UserIdFieldKeyword, GetDatabaseNameForTenantID(connectionName, UserIdFieldKeyword));
            connectionStringBuilder.Add(PasswordFieldKeyword, GetDatabaseNameForTenantID(connectionName, PasswordFieldKeyword));
            return connectionStringBuilder.ConnectionString;
        }
        public string GetDatabaseName(string connectionName)
        {
            var Client = clientConfigOptions.Value.Clients.FirstOrDefault(x => x.Code.Equals(connectionName, StringComparison.InvariantCultureIgnoreCase));
            if (Client == null)
            {
                throw new ConfigurationErrorsException(string.Format("Specified client configuration entry doesnt exist [Client:{0}]", connectionName));
            }
            var ClientConnectionSetup = Client.AppClientConnection.FirstOrDefault(x => x.ConnectionType == (int)ConnectionType.DBMain);
            if (ClientConnectionSetup == null)
            {
                throw new ConfigurationErrorsException(string.Format("client connection main database configuration entry doesnt exist [Client:{0}]", connectionName));
            }

            return ClientConnectionSetup.Dbname;
        }
        public string GetDatabaseNameForTenantID(string TenantId, string connectionKey = "")
        {
            string connectionValue = string.Empty;
            var Client = clientConfigOptions.Value.Clients.FirstOrDefault(x => x.ClientGuid.Equals(TenantId, StringComparison.InvariantCultureIgnoreCase));
            if (Client == null)
            {
                throw new ConfigurationErrorsException(string.Format("Specified client configuration entry doesnt exist [Client:{0}]", TenantId));
            }
            var ClientConnectionSetup = Client.AppClientConnection.FirstOrDefault(x => x.ConnectionType == (int)ConnectionType.DBMain);
            if (ClientConnectionSetup == null)
            {
                throw new ConfigurationErrorsException(string.Format("client connection main database configuration entry doesnt exist [Client:{0}]", TenantId));
            }

            switch (connectionKey)
            {
                case DefaultConstants.Server:
                    connectionValue = ClientConnectionSetup.ServerName;
                    break;
                case DefaultConstants.Database:
                    connectionValue = ClientConnectionSetup.Dbname;
                    break;
                case DefaultConstants.Uid:
                    connectionValue = ClientConnectionSetup.UserId;
                    break;
                case DefaultConstants.Pwd:
                    connectionValue = ClientConnectionSetup.Pwd;
                    break;
                default:
                    connectionValue = ClientConnectionSetup.Dbname;
                    break;
            }
            return connectionValue;
        }
        private void RetryOpenConnection(IDbConnection connection)
        {
            int attempts = 0;
            while (attempts < 3)
            {
                try
                {

                    connection.Open();
                    break;
                }
                catch (System.Exception)
                {
                    attempts++;
                    System.Threading.Thread.Sleep(10);
                    if (attempts > 2)
                        throw;
                    else
                        continue;
                }
            }
        }
        public string GetYellowfinClientConnectionString(string connectionName)
        {
         /*   DecryptValueUtility decrypt = new DecryptValueUtility();*/
            ValidateDefaultConnection();
            if (connectionName == null) throw new ArgumentNullException("connectionName");
            var connectionStringBuilder = GetConnectionStringBuilder();
            var client = clientConfigOptions.Value.Clients.FirstOrDefault(x => x.Code.Equals(connectionName, StringComparison.InvariantCultureIgnoreCase));
            connectionStringBuilder.Remove(DatabaseFieldKeyword);
            connectionStringBuilder.Remove(ServerFieldKeyword);
            connectionStringBuilder.Remove(UserIdFieldKeyword);
            connectionStringBuilder.Remove(PasswordFieldKeyword);
  /*          connectionStringBuilder.Add(ServerFieldKeyword, decrypt.GetDecryptValue(client.YFServer));
            connectionStringBuilder.Add(DatabaseFieldKeyword, decrypt.GetDecryptValue(client.YFDatabase));
            connectionStringBuilder.Add(UserIdFieldKeyword, decrypt.GetDecryptValue(client.YFUserId));
            connectionStringBuilder.Add(PasswordFieldKeyword, decrypt.GetDecryptValue(client.YFPassword));*/

            return connectionStringBuilder.ConnectionString;
        }

        public IDbConnection CreateConnectionForYellowFin(string connectionName)
        {
            string clientConnectionString = GetYellowfinClientConnectionString(connectionName);
            var connection = _provider.CreateConnection();
            if (connection == null)
                throw new Exception(string.Format("Failed to create a connection using the connection string named '{0}' in app/web.config.", _name));
            connection.ConnectionString = clientConnectionString;
            RetryOpenConnection(connection);
            return connection;
        }
        public IDbConnection Create(string connectionName)
        {

            string clientConnectionString = GetClientConnectionString(connectionName);
            var connection = _provider.CreateConnection();
            if (connection == null)
                //throw new ConfigurationErrorsException(string.Format("Failed to create a connection using the connection string named '{0}' in app/web.config.", _name));
                throw new Exception(string.Format("Failed to create a connection using the connection string named '{0}' in app/web.config.", _name));

            connection.ConnectionString = clientConnectionString;
            //connection.Open ();
            RetryOpenConnection(connection);
            return connection;
        }
       /* public IDbConnection Create()
        {
            var connection = _provider.CreateConnection();

            if (connection == null)
                //throw new ConfigurationErrorsException(string.Format("Failed to create a connection using the connection string named '{0}' in app/web.config.", _name));
                throw new Exception(string.Format("Failed to create a connection using the connection string named '{0}' in app/web.config.", _name));

            connection.ConnectionString = _connectionString;
            // connection.Open ();
            RetryOpenConnection(connection);
            return connection;
        }*/
        public IDbDataAdapter GetDataAdapter(IDbCommand command)
        {
            //DbDataAdapter adapter = AssemblyProvider.GetInstance(this._providerName).Factory.CreateDataAdapter();
            DbDataAdapter adapter = _provider.CreateDataAdapter();
            adapter.SelectCommand = (DbCommand)command;
            return adapter;
        }
    }
}
