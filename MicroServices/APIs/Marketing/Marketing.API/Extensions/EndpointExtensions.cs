using Marketing.DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace Marketing.Extensions;

public static class MarketingExtensions {
    public static WebApplication MapMarketingExtensions(this WebApplication app)
    {
        app.MapGet("/", () => "Hello World from marketing service!");
        app.MapGet("/customers/{id}", ([FromServices] IMarketingRepository repo, int id) => repo.GetByIdAsync(id));
        app.MapGet("/customers", ([FromServices] IMarketingRepository repo) => repo.GetAllAsync());
        app.MapPost("/customer",
            ([FromServices] IMarketingRepository repo, [FromBody] Customer customer) => repo.AddAsync(customer));

        return app;
    }
}