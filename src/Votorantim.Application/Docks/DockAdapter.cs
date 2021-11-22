using Votorantim.Application.Base;
using Votorantim.Domain.Aggregates.Docks.Entities;

namespace Votorantim.Application.Docks
{
    public class DockAdapter: IAdapter<DockRequest, DockResponse, Dock>
    {
        public Dock Adapt(DockRequest request)
        {
            return new Dock()
            {
                Name = request.Name,
                CheckPoints = request.CheckPoints,
            };
        }

        public DockResponse Adapt(Dock record)
        {
            return new DockResponse()
            {
                Id = record.Id,
                Name = record.Name,
                CheckPoints = record.CheckPoints,
                ValidationResult = record.ValidationResult
            };
        }
    }
}
