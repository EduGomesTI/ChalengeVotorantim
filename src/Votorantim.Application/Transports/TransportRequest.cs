using Votorantim.Application.Base;

namespace Votorantim.Application.Transports
{
    public class TransportRequest : IRequest
    {
        public string TicketId { get; set; }
        public string DeviceId { get; set; }
    }
}
