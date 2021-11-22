using Votorantim.Data.Repositories.Base;
using Votorantim.Domain.Aggregates.Tickets.Entities;
using Votorantim.Domain.Aggregates.Tickets.Interfaces;
using Votorantim.Domain.Base.MongoDB;

namespace Votorantim.Data.Repositories.Tickets
{
    public class TicketRepository : BaseRepository<Ticket, string>, ITicketRepository
    {
        public TicketRepository(IMongoDBContext mongoDBContext) : base(mongoDBContext, "ticket")
        {
        }
    }
}
