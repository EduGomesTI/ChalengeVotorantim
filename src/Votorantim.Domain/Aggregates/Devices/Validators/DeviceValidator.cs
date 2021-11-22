using FluentValidation;
using Votorantim.Domain.Aggregates.Devices.Entites;

namespace Votorantim.Domain.Aggregates.Devices.Validators
{
    public class DeviceValidator : AbstractValidator<Device>
    {
        public DeviceValidator()
        {
            RuleSet("new", () => 
            {
                RuleFor(d => d.Location)
                .NotEmpty()
                .WithMessage("{PropertyName} can not be empty");
            });
        }
    }
}
