using FluentValidation.Results;
using Votorantim.Application.Base;
using Votorantim.Domain.Aggregates.Docks.Entities;

namespace Votorantim.Application.Docks
{
    public struct DockResponse: IResponse
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public List<CheckPoint> CheckPoints { get; set; }
        public ValidationResult ValidationResult { get; set; }
    }
}
