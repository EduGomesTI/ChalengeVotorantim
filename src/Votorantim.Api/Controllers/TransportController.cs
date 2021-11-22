using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;
using Votorantim.Application.Base;
using Votorantim.Application.Transports;

namespace Votorantim.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransportController : ControllerBase
    {
        public readonly ITransportAppService<TransportRequest, TransportResponse> _transportAppService;

        public TransportController(ITransportAppService<TransportRequest, TransportResponse> transportAppService)
        {
            _transportAppService = transportAppService;
        }

        [HttpGet]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(TransportResponse), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces(MediaTypeNames.Application.Json)]
        public async Task<IActionResult> ShowRoute([FromBody] TransportRequest request)
        {
            var result = await _transportAppService.ShowRoute(request);

            return Ok(result);
        }
    }
}
