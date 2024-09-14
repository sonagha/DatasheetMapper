using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DatasheetService.KSBasePayloadDTO;

namespace DatasheetService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DatasheetServiceController : Controller
    {
        private readonly ILogger<DatasheetServiceController> _logger;
        private readonly OperatingPoint _payloadDAO;

        public DatasheetServiceController(ILogger<DatasheetServiceController> logger, OperatingPoint payloadDAO)
        {
            _logger = logger;
            _payloadDAO = payloadDAO;
        }

        [HttpPost("CreateDatasheet")]
        [Consumes("application/json")]
        public IActionResult Post([FromBody] KSBasePayload payload)
        {
            if (payload == null)
            {
                _logger.LogError("Received null payload");
                return BadRequest("Payload is null");
            }

            try
            {
                var combinedData = _payloadDAO.CombineData(payload);
                _logger.LogInformation("Processing payload: {Payload}", payload);
                return Ok(combinedData);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while processing the payload");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
