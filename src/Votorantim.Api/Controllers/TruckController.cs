using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;
using Votorantim.Application.Base;
using Votorantim.Application.Trucks;

namespace Votorantim.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TruckController : ControllerBase
    {
        private readonly IAppService<TruckRequest, TruckResponse> _truckAppService;

        public TruckController(IAppService<TruckRequest, TruckResponse> truckAppService)
        {
            _truckAppService = truckAppService;
        }

        [HttpPost]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(TruckResponse), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces(MediaTypeNames.Application.Json)]
        public async Task<IActionResult> AddTruck([FromBody] TruckRequest request)
        {
            var result = await _truckAppService.AddAsync(request);

            return Created("", result);
        }

        [HttpGet(template: "{id}")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(TruckResponse), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces(MediaTypeNames.Application.Json)]
        public async Task<IActionResult> FindTruckById(string id)
        {
            var result = await _truckAppService.FIndByIdAsync(id);

            return  Ok(result);
        }

        [HttpGet]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(TruckResponse), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces(MediaTypeNames.Application.Json)]
        public async Task<IActionResult> FindAllTrucks()
        {
            var result = await _truckAppService.FindAllAsync();

            return Ok(result);
        }
    }
}
