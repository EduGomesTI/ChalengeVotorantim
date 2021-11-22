using Votorantim.Domain.Aggregates;

namespace Votorantim.Domain.Base.Repository
{
    public interface IBaseRepository<TEntity, TId> where TEntity: BaseEntity<TId>
    {
        Task<TEntity> GetByIdAsync(TId id);
        Task<TEntity> AddAsync(TEntity entity);
        Task<IList<TEntity>> GetAllAsync();
    }
}
