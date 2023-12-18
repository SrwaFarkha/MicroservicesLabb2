using Microsoft.EntityFrameworkCore;
using Marketing.DataAccess;

var builder = WebApplication.CreateBuilder(args);

var host = Environment.GetEnvironmentVariable("DB_HOST");
var database = Environment.GetEnvironmentVariable("DB_DATABASE");
var username = Environment.GetEnvironmentVariable("DB_USER");
var password = Environment.GetEnvironmentVariable("DB_MSSQL_SA_PASSWORD");
var connectionString =
    $"Data Source={host};Initial Catalog={database};User ID={username};Password={password};Trusted_connection=False;TrustServerCertificate=True;";

builder.Services.AddSqlServer<MarketingContext>(connectionString);
builder.Services.AddScoped<IMarketingRepository, MarketingRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseHsts();
}

app.MapGet("/", () => "Hello World!");

app.Run();
