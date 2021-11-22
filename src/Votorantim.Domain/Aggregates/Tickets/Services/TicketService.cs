using Votorantim.Domain.Aggregates.Docks.Intefaces.Repositories;
using Votorantim.Domain.Aggregates.Tickets.Entities;
using Votorantim.Domain.Aggregates.Tickets.Interfaces;
using Votorantim.Domain.Aggregates.Trucks.Interfaces.Repositories;

namespace Votorantim.Domain.Aggregates.Tickets.Services
{
    public class TicketService : ITicketService
    {
        private readonly ITicketRepository _ticketRepository;
        private readonly ITruckRepository _truckRepository;
        private readonly IDockRepository _dockRepository;

        public TicketService(ITicketRepository ticketRepository, 
                             ITruckRepository truckRepository, 
                             IDockRepository dockRepository)
        {
            _ticketRepository = ticketRepository;
            _truckRepository = truckRepository;
            _dockRepository = dockRepository;
        }

        public async Task<Ticket> AddTicketAsync(Ticket ticket)
        {
            var truck = await _truckRepository.GetByIdAsync(ticket.Truck.Id);

            var dock = await _dockRepository.GetByIdAsync(ticket.Dock.Id);

            ticket.Truck = truck;
            ticket.Dock = dock;            
            
            return await _ticketRepository.AddAsync(ticket);
        }

        public async Task<IList<Ticket>> GetAllTicketsAsync()
        {
            return await _ticketRepository.GetAllAsync();
        }

        public async Task<Ticket> GetTicketByIdAsync(string id)
        {
            return await _ticketRepository.GetByIdAsync(id);
        }
    }
}
