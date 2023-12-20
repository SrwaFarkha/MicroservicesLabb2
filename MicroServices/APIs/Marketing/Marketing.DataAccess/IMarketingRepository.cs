using Domain.Common.Interfaces.DataAccess;

namespace Marketing.DataAccess;

public interface IMarketingRepository : IGenericRepository<Customer, int>
{

}