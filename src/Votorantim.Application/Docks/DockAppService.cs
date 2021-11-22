using Votorantim.Application.Base;
using Votorantim.Domain.Aggregates.Docks.Intefaces.Services;

namespace Votorantim.Application.Docks
{
    public class DockAppService : IAppService<DockRequest, DockResponse>
    {
        private readonly IDockService _dockService;

        public DockAppService(IDockService dockService)
        {
            _dockService = dockService;
        }

        public async Task<DockResponse> AddAsync(DockRequest request)
        {
            var adapter = new DockAdapter();

            var dock = adapter.Adapt(request);

            dock = await _dockService.AddDockAsync(dock);

            return adapter.Adapt(dock);
        }

        public async Task<IList<DockResponse>> FindAllAsync()
        {
            var docks = await _dockService.GetAllDocksAsync();

            var adapter = new DockAdapter();

            return (from dock in docks
                    select adapter.Adapt(dock)).ToList();
        }

        public async Task<DockResponse> FIndByIdAsync(string id)
        {
            var dock = await _dockService.GetDockByIdAsync(id);

            var adapter = new DockAdapter();

            return adapter.Adapt(dock);
        }                
    }
}
