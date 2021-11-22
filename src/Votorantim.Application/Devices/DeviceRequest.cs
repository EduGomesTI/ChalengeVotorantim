using Votorantim.Application.Base;

namespace Votorantim.Application.Devices
{
    public struct DeviceRequest: IRequest
    {
        public string Location { get; set; }
    }
}
