+=============================================================================================================+
|                                     🔷 ASP.NET CORE APPLICATION STARTUP FLOW (DETAILED)                     |
+=============================================================================================================+
|                                                                                                             |
| 🔹 1. PROGRAM.CS (Main Entry)                                                                               |
|    +-----------------------------------------------------------------------------------------------+        |
|    | - Initializes the application                                                                   |      |
|    | - Creates WebApplicationBuilder                                                                 |      |
|    | - Adds services to DI container                                                                 |      |
|    | - Builds WebApplication object                                                                   |      |
|    | - Starts HTTP server via app.Run()                                                              |      |
|    +-----------------------------------------------------------------------------------------------+        |
|    | 📌 Sample:                                                                                        |      |
|    | var builder = WebApplication.CreateBuilder(args);                                                |      |
|    | var app = builder.Build();                                                                       |      |
|    | app.Run();                                                                                        |      |
|                                                                                                             |
| 🔹 2. LOAD CONFIGURATION FILES                                                                          |
|    +-----------------------------------------------------------------------------------------------+        |
|    | - Reads from:                                                                                   |      |
|    |   ✔ appsettings.json                                                                            |      |
|    |   ✔ appsettings.{Environment}.json                                                              |      |
|    |   ✔ secrets.json (dev only)                                                                      |      |
|    |   ✔ Environment variables, command-line args                                                     |      |
|    | - Access via IConfiguration                                                                      |      |
|    +-----------------------------------------------------------------------------------------------+        |
|    | 📌 Example: configuration["Logging:LogLevel:Default"]                                            |      |
|                                                                                                             |
| 🔹 3. CONFIGURE SERVICES (Dependency Injection)                                                          |
|    +-----------------------------------------------------------------------------------------------+        |
|    | - Register services into DI container                                                            |      |
|    | - Lifetime:                                                                                      |      |
|    |   ✔ Singleton   - One instance for lifetime of app                                               |      |
|    |   ✔ Scoped      - Per HTTP request                                                               |      |
|    |   ✔ Transient   - New instance every time                                                         |      |
|    | - Examples: DbContext, Logging, Custom Services, Repositories                                     |      |
|    +-----------------------------------------------------------------------------------------------+        |
|    | 📌 Example:                                                                                        |      |
|    | services.AddScoped<IUserService, UserService>();                                                  |      |
|    | services.AddDbContext<AppDbContext>();                                                            |      |
|                                                                                                             |
| 🔹 4. ADD FRAMEWORK SERVICES                                                                           |
|    +-----------------------------------------------------------------------------------------------+        |
|    | - Adds built-in features like:                                                                    |      |
|    |   ✔ AddControllers()                                                                             |      |
|    |   ✔ AddAuthentication()                                                                          |      |
|    |   ✔ AddSwaggerGen()                                                                              |      |
|    |   ✔ AddCors()                                                                                     |      |
|    +-----------------------------------------------------------------------------------------------+        |
|    | 📌 Example:                                                                                        |      |
|    | services.AddControllers();                                                                        |      |
|    | services.AddSwaggerGen();                                                                         |      |
|                                                                                                             |
| 🔹 5. BUILD MIDDLEWARE PIPELINE                                                                       |
|    +-----------------------------------------------------------------------------------------------+        |
|    | - Middleware is executed top-down in order                                                        |      |
|    | - Common Middleware:                                                                              |      |
|    |   ✔ UseDeveloperExceptionPage() (Dev only)                                                       |      |
|    |   ✔ UseSwagger() + UseSwaggerUI()                                                                |      |
|    |   ✔ UseCors()                                                                                    |      |
|    |   ✔ UseRouting()                                                                                 |      |
|    |   ✔ UseAuthentication() + UseAuthorization()                                                    |      |
|    |   ✔ UseStaticFiles()                                                                             |      |
|    +-----------------------------------------------------------------------------------------------+        |
|                                                                                                             |
| 🔹 6. MAP CONTROLLER ROUTES                                                                          |
|    +-----------------------------------------------------------------------------------------------+        |
|    | - Endpoint routing to map HTTP request → controller/action                                       |      |
|    | - Convention-based or attribute routing                                                          |      |
|    | - Default route pattern:                                                                         |      |
|    |   {controller=Home}/{action=Index}/{id?}                                                         |      |
|    +-----------------------------------------------------------------------------------------------+        |
|    | 📌 Example:                                                                                        |      |
|    | app.MapControllerRoute(                                                                          |      |
|    |     name: "default",                                                                             |      |
|    |     pattern: "{controller=Home}/{action=Index}/{id?}");                                          |      |
|                                                                                                             |
| 🔹 7. START APPLICATION (app.Run())                                                                   |
|    +-----------------------------------------------------------------------------------------------+        |
|    | - Kestrel HTTP server starts                                                                     |      |
|    | - Listens to configured URL/port (launchSettings.json or env var)                               |      |
|    | - Accepts HTTP requests                                                                          |      |
|    +-----------------------------------------------------------------------------------------------+        |
|    | 📌 Example:                                                                                        |      |
|    | app.Run();                                                                                        |      |
|                                                                                                             |
+=============================================================================================================+
| 🔁 SUMMARY FLOW:                                                                                            |
|  Program.cs ➤ Load Config ➤ Register Services ➤ Add Framework ➤ Middleware ➤ Routes ➤ Run Server          |
+=============================================================================================================+
