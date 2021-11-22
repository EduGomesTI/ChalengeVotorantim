

using Votorantim.Application.Base;
using Votorantim.Domain.Aggregates.Trucks.Entities;

namespace Votorantim.Application.Trucks
{
    public class TruckAdapter : IAdapter<TruckRequest, TruckResponse, Truck>
    {
        public Truck Adapt(TruckRequest request)
        {
            return new Truck()
            {
                Drivername = request.Drivername,
                LicensePlate = request.LicensePlate
            };
        }

        public TruckResponse Adapt(Truck record)
        {
            return new TruckResponse()
            {
                Id = record.Id,
                Drivername = record.Drivername,
                LicensePlate = record.LicensePlate,
                ValidationResult = record.ValidationResult
            };
        }
    }
}
