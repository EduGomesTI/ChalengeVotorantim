using Votorantim.Application.Base;
using Votorantim.Domain.Aggregates.Devices.Interfaces.Services;

namespace Votorantim.Application.Devices
{
    public class DeviceAppService : IAppService<DeviceRequest, DeviceReponse>
    {
        private readonly IDeviceService _deviceService;
        public DeviceAppService(IDeviceService deviceService)
        {
            _deviceService = deviceService;
        }

        public async Task<DeviceReponse> AddAsync(DeviceRequest request)
        {
            var adapter = new DeviceAdapter();

            var device = adapter.Adapt(request);

            device = await _deviceService.AddDeviceAsync(device);

            return adapter.Adapt(device);
        }

        public async Task<IList<DeviceReponse>> FindAllAsync()
        {
            var devices = await _deviceService.GetAllDevicesAsync();

            var adapter = new DeviceAdapter();

            return (from device in devices
                    select adapter.Adapt(device)).ToList();
        }

        public async Task<DeviceReponse> FIndByIdAsync(string id)
        {
            var device = await _deviceService.GetDeviceByIdAsync(id);

            var adapter = new DeviceAdapter();

            return adapter.Adapt(device);
        }
    }
}
