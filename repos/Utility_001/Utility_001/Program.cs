/**//*using Microsoft.AspNetCore.Connections;*//*
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Utility_001.Data;
using Utility_001.Libs.DAL;
using Utility_001.Libs.Entities;
using Utility_001.Repository;
using Utility_001.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IConnectionFactory>(sp =>
{
    var httpContextAccessor = sp.GetService<IHttpContextAccessor>();
    var connectionSettings = sp.GetService<IOptions<ConnectionSettings>>();
    var clientConfigOptions = sp.GetService<IOptions<AppClientConfig>>();

    if (httpContextAccessor != null && connectionSettings != null && clientConfigOptions != null)
    {
        return new DbConnectionFactory(httpContextAccessor, connectionSettings, clientConfigOptions);
    }

    throw new InvalidOperationException("Cannot resolve DbConnectionFactory due to missing dependencies.");
});

builder.Services.Configure<ConnectionSettings>(builder.Configuration.GetSection("ConnectionSettings"));
builder.Services.AddScoped<AdoDBContext>();
builder.Services.Configure<AppClientConfig>(builder.Configuration.GetSection("AppClientConfig"));

builder.Services.AddHttpContextAccessor();
builder.Configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
builder.Configuration.AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", optional: true);

builder.Services.AddScoped<ISampleIPRepository, SampleIPRepository>();
builder.Services.AddScoped<ISampleIPService, SampleIPService>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngular", policy =>
    {
        policy.WithOrigins("http://localhost:4200")
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseSwagger();
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "My API v1");
    options.RoutePrefix = "";
});


app.UseCors("AllowAngular");
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
*/

































using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Utility_001.Data;
using Utility_001.Libs.DAL;
using Utility_001.Libs.Entities;
using Utility_001.Repository;
using Utility_001.Services;

var builder = WebApplication.CreateBuilder(args);

// Add JSON files for configuration
builder.Configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
builder.Configuration.AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", optional: true);

// Configure connection settings
builder.Services.Configure<ConnectionSettings>(builder.Configuration.GetSection("ConnectionStrings"));
builder.Services.Configure<AppClientConfig>(builder.Configuration.GetSection("AppClientConfig"));

// Add HttpContext accessor
builder.Services.AddHttpContextAccessor();



// Add AdoDBContext
builder.Services.AddScoped<AdoDBContext>();

// Add repositories and services
builder.Services.AddScoped<ISampleIPRepository, SampleIPRepository>();
builder.Services.AddScoped<ISampleIPService, SampleIPService>();
/*builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IProductService, ProductService>();*/

// Add CORS policy
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngular", policy =>
    {
        policy.WithOrigins("http://localhost:4200")
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});
builder.Services.AddScoped<IConnectionFactory>(sp =>
{
    var httpContextAccessor = sp.GetService<IHttpContextAccessor>();
    var connectionSettings = sp.GetService<IOptions<ConnectionSettings>>();
    var clientConfigOptions = sp.GetService<IOptions<AppClientConfig>>();

    if (httpContextAccessor != null && connectionSettings != null && clientConfigOptions != null)
    {
        return new DbConnectionFactory(httpContextAccessor, connectionSettings, clientConfigOptions);
    }

    throw new InvalidOperationException("Cannot resolve DbConnectionFactory due to missing dependencies.");
});

// Handle multi-tenancy configuration dynamically
builder.Host.ConfigureAppConfiguration((hostingContext, configBuilder) =>
{
    var configuration = configBuilder.Build();
    var connectionSettings = configuration.GetSection("ConnectionStrings").Get<ConnectionSettings>();


});



// Add controllers and Swagger
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure middleware for development
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "My API v1");
        options.RoutePrefix = "";
    });
}

// Configure middleware for production
app.UseCors("AllowAngular");
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

// Map default controller route
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
