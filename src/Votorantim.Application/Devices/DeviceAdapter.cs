using Votorantim.Application.Base;
using Votorantim.Domain.Aggregates.Devices.Entites;

namespace Votorantim.Application.Devices
{
    public class DeviceAdapter : IAdapter<DeviceRequest, DeviceReponse, Device>
    {
        public Device Adapt(DeviceRequest request)
        {
            return new Device()
            {
                Location = request.Location
            };
        }

        public DeviceReponse Adapt(Device record)
        {
            return new DeviceReponse()
            {
                Id = record.Id,
                Location = record.Location,
                ValidationResult = record.ValidationResult
            };
        }
    }
}
