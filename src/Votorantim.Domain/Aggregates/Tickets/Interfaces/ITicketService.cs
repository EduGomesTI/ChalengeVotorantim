using Votorantim.Domain.Aggregates.Tickets.Entities;

namespace Votorantim.Domain.Aggregates.Tickets.Interfaces
{
    public interface ITicketService
    {
        Task<Ticket> AddTicketAsync(Ticket ticket);
        Task<Ticket> GetTicketByIdAsync(string id);
        Task<IList<Ticket>> GetAllTicketsAsync();
    }
}
