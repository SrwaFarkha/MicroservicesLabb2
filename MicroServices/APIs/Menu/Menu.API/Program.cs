using FastEndpoints;
using Menu.DataAccess;

var builder = WebApplication.CreateBuilder(args);
//lägga till services
//(strategy pattern)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddFastEndpoints();
builder.Services.AddScoped<IMenuRepository, MenuRepository>();

var app = builder.Build();

//Middle pipeline(saker vi lägger upp som ska hämta våra request)

app.UseHttpsRedirection();
app.UseRouting();

app.UseFastEndpoints();


app.Run();
