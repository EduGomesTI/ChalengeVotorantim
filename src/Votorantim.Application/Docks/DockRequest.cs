using Votorantim.Application.Base;
using Votorantim.Domain.Aggregates.Docks.Entities;

namespace Votorantim.Application.Docks
{
    public struct DockRequest: IRequest
    {
        public string Name { get; set; }
        public List<CheckPoint> CheckPoints { get; set; }
    }
}
