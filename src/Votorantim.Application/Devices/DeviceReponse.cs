using FluentValidation.Results;
using Votorantim.Application.Base;

namespace Votorantim.Application.Devices
{
    public struct DeviceReponse : IResponse
    {
        public string Id { get; set; }
        public string Location { get; set; }
        public ValidationResult ValidationResult { get; set; }
    }
}
