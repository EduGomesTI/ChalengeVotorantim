using Votorantim.Domain.Aggregates.Devices.Entites;
using Votorantim.Domain.Base.Repository;

namespace Votorantim.Domain.Aggregates.Devices.Interfaces.Repositories
{
    public interface IDeviceRepository: IBaseRepository<Device, string>
    {
    }
}
