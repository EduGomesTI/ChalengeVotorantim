using FluentValidation.Results;
using Votorantim.Application.Base;

namespace Votorantim.Application.Trucks
{
    public struct TruckResponse: IResponse
    {
        public string Id { get; set; }
        public string Drivername { get; set; }
        public string LicensePlate { get; set; }
        public ValidationResult ValidationResult { get; set; }
    }
}
