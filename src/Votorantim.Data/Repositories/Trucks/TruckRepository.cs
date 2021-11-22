using Votorantim.Data.Repositories.Base;
using Votorantim.Domain.Aggregates.Trucks.Entities;
using Votorantim.Domain.Aggregates.Trucks.Interfaces.Repositories;
using Votorantim.Domain.Base.MongoDB;

namespace Votorantim.Data.Repositories.Trucks
{
    public class TruckRepository : BaseRepository<Truck, string>, ITruckRepository
    {
        public TruckRepository(IMongoDBContext mongoDBContext) : base(mongoDBContext, "truck")
        {
        }
    }
}
