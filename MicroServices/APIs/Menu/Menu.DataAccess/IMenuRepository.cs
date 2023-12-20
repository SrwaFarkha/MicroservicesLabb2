using Domain.Common.Interfaces.DataAccess;
using static System.Formats.Asn1.AsnWriter;
namespace Menu.DataAccess;

public interface IMenuRepository : IGenericRepository<Menu, int>
{
	//Task<IEnumerable<Menu>> GetMenuAsync(int id, CancellationToken cancellationToken);

}