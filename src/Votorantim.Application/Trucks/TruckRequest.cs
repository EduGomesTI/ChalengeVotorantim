using Votorantim.Application.Base;

namespace Votorantim.Application.Trucks
{
    public struct TruckRequest : IRequest
    {
        public string Drivername { get; set; }
        public string LicensePlate { get; set; }
    }
}
