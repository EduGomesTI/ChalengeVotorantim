using Votorantim.Application.Base;
using Votorantim.Domain.Aggregates.Transports.Interfaces.Service;

namespace Votorantim.Application.Transports
{
    public class TransportAppService : ITransportAppService<TransportRequest, TransportResponse>
    {
        private readonly ITransportService _service;

        public TransportAppService(ITransportService service)
        {
            _service = service;
        }

        public async Task<TransportResponse> ShowRoute(TransportRequest request)
        {
           var transport = await _service.ShowRoute(request.TicketId, request.DeviceId);

            var adapter = new TransportAdapter();

            return adapter.Adapt(transport);
        }
    }
}
