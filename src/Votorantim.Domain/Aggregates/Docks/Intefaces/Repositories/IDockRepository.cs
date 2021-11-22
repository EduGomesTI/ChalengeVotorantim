using Votorantim.Domain.Aggregates.Docks.Entities;
using Votorantim.Domain.Base.Repository;

namespace Votorantim.Domain.Aggregates.Docks.Intefaces.Repositories
{
    public interface IDockRepository : IBaseRepository<Dock, string>
    {
    }
}
