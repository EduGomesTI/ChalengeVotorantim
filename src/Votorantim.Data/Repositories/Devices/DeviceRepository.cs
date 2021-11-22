using Votorantim.Data.Repositories.Base;
using Votorantim.Domain.Aggregates.Devices.Entites;
using Votorantim.Domain.Aggregates.Devices.Interfaces.Repositories;
using Votorantim.Domain.Base.MongoDB;

namespace Votorantim.Data.Repositories.Devices
{
    public class DeviceRepository : BaseRepository<Device, string>, IDeviceRepository
    {
        public DeviceRepository(IMongoDBContext mongoDBContext) : base(mongoDBContext, "device")
        {
        }
    }
}
