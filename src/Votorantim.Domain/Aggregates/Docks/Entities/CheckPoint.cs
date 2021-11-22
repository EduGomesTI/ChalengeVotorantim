using Votorantim.Domain.Aggregates.Devices.Entites;
using Votorantim.Domain.Aggregates.Docks.Enums;

namespace Votorantim.Domain.Aggregates.Docks.Entities
{
    public record CheckPoint
    {
        public Device Device { get; set; }
        public Direction Direction { get; set; }
    }
}
