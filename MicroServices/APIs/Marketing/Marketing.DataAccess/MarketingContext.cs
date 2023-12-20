using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;

namespace Marketing.DataAccess;

public class MarketingContext : DbContext
{
    public virtual DbSet<Customer> Customers { get; set; } = null!;
    public MarketingContext(DbContextOptions<MarketingContext> options) : base(options)
    {
        try
        {
            if (Database.GetService<IDatabaseCreator>() is RelationalDatabaseCreator databaseCreator)
            {
                if(!databaseCreator.CanConnect()) databaseCreator.Create();
                if(!databaseCreator.HasTables()) databaseCreator.CreateTables();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

