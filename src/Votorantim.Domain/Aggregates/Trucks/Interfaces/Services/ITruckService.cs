using Votorantim.Domain.Aggregates.Trucks.Entities;

namespace Votorantim.Domain.Aggregates.Trucks.Interfaces.Services
{
    public interface ITruckService
    {
        Task<Truck> AddTruckAsync(Truck truck);
        Task<Truck> GetTruckByIdAsync(string Id);
        Task<IList<Truck>> GetAllTrucksAsync();
    }
}
