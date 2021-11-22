using Votorantim.Domain.Aggregates.Tickets.Entities;
using Votorantim.Domain.Base.Repository;

namespace Votorantim.Domain.Aggregates.Tickets.Interfaces
{
    public  interface ITicketRepository : IBaseRepository<Ticket, string>
    {
    }
}
