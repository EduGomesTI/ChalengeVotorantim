using FluentValidation;
using Votorantim.Domain.Aggregates.Trucks.Entities;

namespace Votorantim.Domain.Aggregates.Trucks.Validators
{
    public class RuleSet : AbstractValidator<Truck>
    {
        public RuleSet()
        {
            RuleSet("New", () =>
            {
                RuleFor(t => t.Id).NotEmpty().WithMessage("{PropertyName} can not be empty.");
                RuleFor(t => t.Drivername).NotEmpty().WithMessage("{PropertyName} can not be empty.");
                RuleFor(t => t.LicensePlate).NotEmpty().WithMessage("{PropertyName} can not be empty.");
            });
        }
    }
}
