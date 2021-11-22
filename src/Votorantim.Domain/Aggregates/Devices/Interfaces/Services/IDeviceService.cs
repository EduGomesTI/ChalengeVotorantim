using Votorantim.Domain.Aggregates.Devices.Entites;

namespace Votorantim.Domain.Aggregates.Devices.Interfaces.Services
{
    public interface IDeviceService
    {
        Task<Device> AddDeviceAsync(Device device);

        Task<Device> GetDeviceByIdAsync(string id);

        Task<IList<Device>> GetAllDevicesAsync();
    }
}
