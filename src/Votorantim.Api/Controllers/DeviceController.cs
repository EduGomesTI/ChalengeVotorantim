using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;
using Votorantim.Application.Base;
using Votorantim.Application.Devices;

namespace Votorantim.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeviceController : ControllerBase
    {
        private readonly IAppService<DeviceRequest,DeviceReponse> _deviceAppService;

        public DeviceController(IAppService<DeviceRequest, DeviceReponse> deviceAppService)
        {
            _deviceAppService = deviceAppService;
        }

        [HttpPost]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(DeviceReponse), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces(MediaTypeNames.Application.Json)]
        public async Task<IActionResult> CreateDevicec([FromBody] DeviceRequest request)
        {
            var result = await _deviceAppService.AddAsync(request);

            if(!result.ValidationResult.IsValid)
            {
                return BadRequest(string.Join('\n', result.ValidationResult.Errors));
            }

            return Created("", result);
        }

        [HttpGet]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(DeviceReponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces(MediaTypeNames.Application.Json)]
        public async Task<IActionResult> GetAllDevices()
        {
            var result = await _deviceAppService.FindAllAsync();

            return Ok(result);
        }

        [HttpGet(template: "{id}")]
        [ProducesResponseType(typeof(DeviceReponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces(MediaTypeNames.Application.Json)]
        public async Task<IActionResult> GetDeviceById(string id)
        {
            var result = await _deviceAppService.FIndByIdAsync(id);

            return Ok(result);
        }
    }
}
