
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Votorantim.Application.Base;
using Votorantim.Application.Devices;
using Votorantim.Application.Docks;
using Votorantim.Application.Tickets;
using Votorantim.Application.Transports;
using Votorantim.Application.Trucks;
using Votorantim.Data.Repositories.Base.MongoDB;
using Votorantim.Data.Repositories.Devices;
using Votorantim.Data.Repositories.Docks;
using Votorantim.Data.Repositories.Tickets;
using Votorantim.Data.Repositories.Trucks;
using Votorantim.Domain.Aggregates.Devices.Entites;
using Votorantim.Domain.Aggregates.Devices.Interfaces.Repositories;
using Votorantim.Domain.Aggregates.Devices.Interfaces.Services;
using Votorantim.Domain.Aggregates.Devices.Services;
using Votorantim.Domain.Aggregates.Devices.Validators;
using Votorantim.Domain.Aggregates.Docks.Intefaces.Repositories;
using Votorantim.Domain.Aggregates.Docks.Intefaces.Services;
using Votorantim.Domain.Aggregates.Docks.Services;
using Votorantim.Domain.Aggregates.Tickets.Interfaces;
using Votorantim.Domain.Aggregates.Tickets.Services;
using Votorantim.Domain.Aggregates.Transports.Interfaces.Service;
using Votorantim.Domain.Aggregates.Transports.Services;
using Votorantim.Domain.Aggregates.Trucks.Interfaces.Repositories;
using Votorantim.Domain.Aggregates.Trucks.Interfaces.Services;
using Votorantim.Domain.Aggregates.Trucks.Services;
using Votorantim.Domain.Base.MongoDB;

namespace Votorantim.CrossCutting
{
    public static class DependencyInjection
    {
        public static void AddDependenciesInjections(this IServiceCollection services)
        {
            services.AddSingleton<IMongoDBContext, MongoDBContext>();
            
            services.AddScoped<IAppService<DeviceRequest, DeviceReponse>, DeviceAppService>();
            services.AddScoped<IDeviceService, DeviceService>();
            services.AddScoped<IDeviceRepository, DeviceRepository>();
            services.AddTransient<IValidator<Device>, DeviceValidator>();

            services.AddScoped<IAppService<DockRequest, DockResponse>, DockAppService>();
            services.AddScoped<IDockService, DockService>();
            services.AddScoped<IDockRepository, DockRepository>();

            services.AddScoped<ITruckRepository, TruckRepository>();
            services.AddScoped<ITruckService, TruckService>();
            services.AddScoped<IAppService<TruckRequest, TruckResponse>, TruckAppService>();

            services.AddScoped<ITicketRepository, TicketRepository>();
            services.AddScoped<ITicketService, TicketService>();
            services.AddScoped<IAppService<TicketRequest, TicketResponse>, TicketAppService>();

            services.AddScoped<ITransportService, TransportService>();
            services.AddScoped<ITransportAppService<TransportRequest, TransportResponse>, TransportAppService>();
        }
    }
}
