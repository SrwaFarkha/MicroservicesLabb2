using Microsoft.EntityFrameworkCore;

namespace Marketing.DataAccess;

public class MarketingRepository(MarketingContext context) : IMarketingRepository
{
    public async Task<Customer> GetByIdAsync(int id)
    {
        return await context.Customers.FirstOrDefaultAsync(c => c.Id == id);
    }

    public async Task<IEnumerable<Customer>> GetAllAsync()
    {
        return await context.Customers.ToListAsync();
    }

    public async Task AddAsync(Customer entity)
    {
        await context.AddAsync(entity);
        await context.SaveChangesAsync();
    }
}