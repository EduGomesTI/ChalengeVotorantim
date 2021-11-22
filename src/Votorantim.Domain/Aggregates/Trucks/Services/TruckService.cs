using Votorantim.Domain.Aggregates.Trucks.Entities;
using Votorantim.Domain.Aggregates.Trucks.Interfaces.Repositories;
using Votorantim.Domain.Aggregates.Trucks.Interfaces.Services;

namespace Votorantim.Domain.Aggregates.Trucks.Services
{
    public class TruckService : ITruckService
    {
        private readonly ITruckRepository _repository;

        public TruckService(ITruckRepository repository)
        {
            _repository = repository;
        }

        public async Task<Truck> AddTruckAsync(Truck truck)
        {
            return await _repository.AddAsync(truck);
        }

        public Task<IList<Truck>> GetAllTrucksAsync()
        {
            return _repository.GetAllAsync();
        }

        public async Task<Truck> GetTruckByIdAsync(string Id)
        {
            return await _repository.GetByIdAsync(Id);
        }
    }
}
