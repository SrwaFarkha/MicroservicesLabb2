using FastEndpoints;
using Menu.DataAccess;

var builder = WebApplication.CreateBuilder(args);
//l�gga till services
//(strategy pattern)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddFastEndpoints();
builder.Services.AddScoped<IMenuRepository, MenuRepository>();

var app = builder.Build();

//Middle pipeline(saker vi l�gger upp som ska h�mta v�ra request)

app.UseHttpsRedirection();
app.UseRouting();

app.UseFastEndpoints();


app.Run();
