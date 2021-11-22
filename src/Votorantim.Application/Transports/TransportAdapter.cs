using Votorantim.Application.Base;
using Votorantim.Domain.Aggregates.Transports.Entities;

namespace Votorantim.Application.Transports
{
    internal class TransportAdapter : IAdapter<TransportRequest, TransportResponse, Transport>
    {
        public Transport Adapt(TransportRequest request)
        {
            return new Transport()
            {
                TicketId = request.TicketId,
                DeviceId = request.DeviceId,
            };
        }

        public TransportResponse Adapt(Transport record)
        {
            return new TransportResponse()
            {
                DirectionMessage = record.DirectionMessage,
                GreetingMessage = record.GreetingMessage,
                LocationMessage = record.LocationMessage,
            };
        }
    }
}
