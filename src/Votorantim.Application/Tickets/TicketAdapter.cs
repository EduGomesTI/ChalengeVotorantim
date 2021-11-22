using Votorantim.Application.Base;
using Votorantim.Domain.Aggregates.Docks.Entities;
using Votorantim.Domain.Aggregates.Tickets.Entities;
using Votorantim.Domain.Aggregates.Trucks.Entities;

namespace Votorantim.Application.Tickets
{
    public class TicketAdapter : IAdapter<TicketRequest, TicketResponse, Ticket>
    {
        public Ticket Adapt(TicketRequest request)
        {
            var truck = new Truck
            {
                Id = request.TruckId
            };

            var dock = new Dock
            {
                Id = request.DockId
            };

            return new Ticket()
            {
                Truck = truck,
                Dock = dock,
                Entrance = DateTime.Now
            };
        }

        public TicketResponse Adapt(Ticket record)
        {
            return new TicketResponse()
            {
                Drivername = record.Truck.Drivername,
                LicensePlate = record.Truck.LicensePlate,
                DockName = record.Dock.Name,
                Entrance = record.Entrance
            };
        }
    }
}
