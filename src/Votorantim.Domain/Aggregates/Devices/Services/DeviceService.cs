using FluentValidation;
using Votorantim.Domain.Aggregates.Devices.Entites;
using Votorantim.Domain.Aggregates.Devices.Interfaces.Repositories;
using Votorantim.Domain.Aggregates.Devices.Interfaces.Services;

namespace Votorantim.Domain.Aggregates.Devices.Services
{
    public class DeviceService : IDeviceService
    {
        private readonly IValidator<Device> _validator;
        private readonly IDeviceRepository _repository;

        public DeviceService(IValidator<Device> validator, IDeviceRepository repository)
        {
            _validator = validator;
            _repository = repository;
        }

        public async Task<Device> AddDeviceAsync(Device device)
        {
          device.ValidationResult = await _validator.ValidateAsync(device, opt => 
          { 
              opt.IncludeRuleSets("new"); 
          });

            if(!device.ValidationResult.IsValid)
            {
                return device;
            }

            return await _repository.AddAsync(device);
        }

        public async Task<IList<Device>> GetAllDevicesAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Device> GetDeviceByIdAsync(string id)
        {
            return await _repository.GetByIdAsync(id);
        }
    }
}
