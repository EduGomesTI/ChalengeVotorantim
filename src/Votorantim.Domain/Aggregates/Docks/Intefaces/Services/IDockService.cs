using Votorantim.Domain.Aggregates.Docks.Entities;

namespace Votorantim.Domain.Aggregates.Docks.Intefaces.Services
{
    public interface IDockService
    {
        Task<Dock> AddDockAsync(Dock dock);
        Task<Dock> GetDockByIdAsync(string id);
        Task<IList<Dock>> GetAllDocksAsync();
    }
}
