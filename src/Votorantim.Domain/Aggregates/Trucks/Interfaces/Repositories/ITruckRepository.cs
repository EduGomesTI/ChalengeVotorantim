using Votorantim.Domain.Aggregates.Trucks.Entities;
using Votorantim.Domain.Base.Repository;

namespace Votorantim.Domain.Aggregates.Trucks.Interfaces.Repositories
{
    public interface ITruckRepository: IBaseRepository<Truck, string>
    {
    }
}
