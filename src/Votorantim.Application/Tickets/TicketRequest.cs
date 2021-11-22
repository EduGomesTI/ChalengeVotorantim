using Votorantim.Application.Base;

namespace Votorantim.Application.Tickets
{
    public struct TicketRequest : IRequest
    {
        public string TruckId { get; set; }
        public string DockId { get; set; }
    }
}
