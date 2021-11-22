using Votorantim.Application.Base;
using Votorantim.Domain.Aggregates.Tickets.Interfaces;

namespace Votorantim.Application.Tickets
{
    public class TicketAppService : IAppService<TicketRequest, TicketResponse>
    {
        private readonly ITicketService _ticketService;

        public TicketAppService(ITicketService ticketService)
        {
            _ticketService = ticketService;
        }

        public async Task<TicketResponse> AddAsync(TicketRequest request)
        {
            var adapter = new TicketAdapter();

            var ticket = adapter.Adapt(request);

            ticket = await _ticketService.AddTicketAsync(ticket);

            return adapter.Adapt(ticket);
        }

        public async Task<IList<TicketResponse>> FindAllAsync()
        {
            var tickets = await _ticketService.GetAllTicketsAsync();

            var adapter = new TicketAdapter();

            return (from ticket in tickets
                    select adapter.Adapt(ticket)).ToList();
        }

        public async Task<TicketResponse> FIndByIdAsync(string id)
        {
            var ticket = await _ticketService.GetTicketByIdAsync(id);

            var adapter = new TicketAdapter();

            return adapter.Adapt(ticket);
        }
    }
}
