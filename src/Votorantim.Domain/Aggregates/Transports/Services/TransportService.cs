using Votorantim.Domain.Aggregates.Docks.Enums;
using Votorantim.Domain.Aggregates.Tickets.Interfaces;
using Votorantim.Domain.Aggregates.Transports.Entities;
using Votorantim.Domain.Aggregates.Transports.Interfaces.Service;

namespace Votorantim.Domain.Aggregates.Transports.Services
{
    public class TransportService : ITransportService
    {
        private readonly ITicketRepository _ticketRepository;

        public TransportService(ITicketRepository ticketRepository)
        {
            _ticketRepository = ticketRepository;
        }

        public async Task<Transport> ShowRoute(string TickeId, string DeviceId)
        {
            var ticket = await _ticketRepository.GetByIdAsync(TickeId);

            var checkPoints = ticket.Dock.CheckPoints;

            var chekPoint = (from cp in checkPoints
                             where cp.Device.Id == DeviceId
                             select cp).FirstOrDefault();    

            string direction = chekPoint.Direction.GetString();

            var transport = new Transport
            {
                TicketId = TickeId,
                DeviceId = DeviceId,
                GreetingMessage = $"Bem vindo {ticket.Truck.Drivername}",
                LocationMessage = $"Você está no {chekPoint.Device.Location}",
                DirectionMessage = direction
            };

            return transport;
        }
    }
}
