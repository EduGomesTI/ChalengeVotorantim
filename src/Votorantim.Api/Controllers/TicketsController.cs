using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;
using Votorantim.Application.Base;
using Votorantim.Application.Tickets;

namespace Votorantim.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketsController : ControllerBase
    {
        private readonly IAppService<TicketRequest, TicketResponse> _appService;

        public TicketsController(IAppService<TicketRequest, TicketResponse> appService)
        {
            _appService = appService;
        }

        [HttpPost]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(TicketResponse), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces(MediaTypeNames.Application.Json)]
        public async Task<IActionResult> CreateDevicec([FromBody] TicketRequest request)
        {
            var result = await _appService.AddAsync(request);

            return Created("", result);
        }

        [HttpGet]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(TicketResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces(MediaTypeNames.Application.Json)]
        public async Task<IActionResult> GetAllDevices()
        {
            var result = await _appService.FindAllAsync();

            return Ok(result);
        }

        [HttpGet(template: "{id}")]
        [ProducesResponseType(typeof(TicketResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces(MediaTypeNames.Application.Json)]
        public async Task<IActionResult> GetDeviceById(string id)
        {
            var result = await _appService.FIndByIdAsync(id);

            return Ok(result);
        }
    }
}
