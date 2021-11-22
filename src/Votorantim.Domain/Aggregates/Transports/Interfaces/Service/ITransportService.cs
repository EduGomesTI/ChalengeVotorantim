using Votorantim.Domain.Aggregates.Transports.Entities;

namespace Votorantim.Domain.Aggregates.Transports.Interfaces.Service
{
    public interface ITransportService
    {
        Task<Transport> ShowRoute(string TickeId, string DeviceId);
    }
}
