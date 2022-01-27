using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Apple_IaP_WebApi2
{
    [ApiController]
    [Route("[controller]")]
    public class IaPController : ControllerBase
    {
        private readonly ILogger<IaPController> _logger;

        public IaPController(ILogger<IaPController> logger)
        {
            _logger = logger;
        }

        [HttpPost("WebHook")]
        public ActionResult WebHook(IaPEvent iaPEvent)
        {
            _logger.LogInformation($"Received IaP event: {iaPEvent.notificationType}");
            return Ok(iaPEvent);
        }
    }
}