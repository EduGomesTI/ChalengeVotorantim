using Votorantim.Application.Base;
using Votorantim.Domain.Aggregates.Trucks.Interfaces.Repositories;

namespace Votorantim.Application.Trucks
{
    public class TruckAppService : IAppService<TruckRequest, TruckResponse>
    {
        private readonly ITruckRepository _repository;

        public TruckAppService(ITruckRepository repository)
        {
            _repository = repository;
        }

        public async Task<TruckResponse> AddAsync(TruckRequest request)
        {
            var adapter = new TruckAdapter();

            var truck = adapter.Adapt(request);

            truck = await _repository.AddAsync(truck);

            return adapter.Adapt(truck);
        }

        public async Task<IList<TruckResponse>> FindAllAsync()
        {
            var trucks = await _repository.GetAllAsync();

            var adapter = new TruckAdapter();

            return (from truck in trucks
                    select adapter.Adapt(truck)).ToList();
        }

        public async Task<TruckResponse> FIndByIdAsync(string id)
        {
            var truck = await _repository.GetByIdAsync(id);

            var adapter = new TruckAdapter();

            return adapter.Adapt(truck);
        }
    }
}
