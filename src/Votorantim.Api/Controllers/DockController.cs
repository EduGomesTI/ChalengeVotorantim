using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;
using Votorantim.Application.Base;
using Votorantim.Application.Docks;

namespace Votorantim.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DockController : ControllerBase
    {
        private readonly IAppService<DockRequest, DockResponse> _dockAppService;

        public DockController(IAppService<DockRequest, DockResponse> dockAppService)
        {
            _dockAppService = dockAppService;
        }

        [HttpPost]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(DockResponse), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces(MediaTypeNames.Application.Json)]
        public async Task<IActionResult> CreateDevicec([FromBody] DockRequest request)
        {
            var result = await _dockAppService.AddAsync(request);

            return Created("", result);
        }

        [HttpGet]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(DockResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces(MediaTypeNames.Application.Json)]
        public async Task<IActionResult> GetAllDevices()
        {
            var result = await _dockAppService.FindAllAsync();

            return Ok(result);
        }

        [HttpGet(template: "{id}")]
        [ProducesResponseType(typeof(DockResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces(MediaTypeNames.Application.Json)]
        public async Task<IActionResult> GetDeviceById(string id)
        {
            var result = await _dockAppService.FIndByIdAsync(id);

            return Ok(result);
        }
    }
}
