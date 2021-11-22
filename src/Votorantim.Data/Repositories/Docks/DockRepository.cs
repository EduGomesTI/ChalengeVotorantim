using Votorantim.Data.Repositories.Base;
using Votorantim.Domain.Aggregates.Docks.Entities;
using Votorantim.Domain.Aggregates.Docks.Intefaces.Repositories;
using Votorantim.Domain.Base.MongoDB;

namespace Votorantim.Data.Repositories.Docks
{
    public class DockRepository : BaseRepository<Dock, string>, IDockRepository
    {
        public DockRepository(IMongoDBContext mongoDBContext) : base(mongoDBContext, "Dock")
        {
        }
    }
}
