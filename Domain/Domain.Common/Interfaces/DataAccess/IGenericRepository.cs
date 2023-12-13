namespace Domain.Common.Interfaces.DataAccess;

public interface IGenericRepository<TEntity, TId> where TEntity : IEntity<TId>
{
	Task<TEntity> GetByIdAsync(TId id);
	Task<IEnumerable<TEntity>> GetAllAsync();
	Task AddAsync(TEntity entity);
}