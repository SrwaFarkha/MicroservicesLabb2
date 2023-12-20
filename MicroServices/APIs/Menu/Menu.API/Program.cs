using FastEndpoints;
using Menu.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);
//l�gga till services
var host = Environment.GetEnvironmentVariable("DB_HOST");
var database = Environment.GetEnvironmentVariable("DB_DATABASE");
var username = Environment.GetEnvironmentVariable("DB_USER");
var password = Environment.GetEnvironmentVariable("DB_MSSQL_SA_PASSWORD");
var connectionString =
	$"Data Source={host};Initial Catalog={database};User ID={username};Password={password};Trusted_connection=False;TrustServerCertificate=True;";

builder.Services.AddSqlServer<MenuDbContext>(connectionString);
builder.Services.AddFastEndpoints();


builder.Services.AddScoped<IMenuRepository, MenuRepository>();

var app = builder.Build();

//Middle pipeline(saker vi l�gger upp som ska h�mta v�ra request)

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
}
app.UseRouting();

app.UseFastEndpoints();

app.Run();
