using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Votorantim.Domain.Aggregates.Docks.Entities;
using Votorantim.Domain.Aggregates.Docks.Intefaces.Repositories;
using Votorantim.Domain.Aggregates.Docks.Intefaces.Services;

namespace Votorantim.Domain.Aggregates.Docks.Services
{
    public class DockService : IDockService
    {
        private readonly IDockRepository _repository;

        public DockService(IDockRepository repository)
        {
            _repository = repository;
        }

        public async Task<Dock> AddDockAsync(Dock dock)
        {
            return await _repository.AddAsync(dock);
        }

        public async Task<IList<Dock>> GetAllDocksAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Dock> GetDockByIdAsync(string id)
        {
            return await _repository.GetByIdAsync(id);
        }
    }
}
