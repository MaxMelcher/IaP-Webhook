using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.IdentityModel.Tokens.Jwt;

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
        /// <summary>
        /// WebHook triggered by Logic App
        /// IaPEent example: https://gist.github.com/MaxMelcher/99562cfb4d906446a7364be63755b6c1
        /// </summary>
        public ActionResult WebHook(IaPEvent iaPEvent)
        {
            _logger.LogInformation($"Received IaP event: {iaPEvent.notificationType}");

            //decode signedTransactionInfo, see https://gist.github.com/MaxMelcher/99562cfb4d906446a7364be63755b6c1#file-signedtransactioninfo-json
            var signedTransactionInfo = new JwtSecurityToken(iaPEvent.data.signedTransactionInfo);
            //decode signedRenewalInfo, see https://gist.github.com/MaxMelcher/99562cfb4d906446a7364be63755b6c1#file-signedrenewalinfo-json
            var signedRenewalInfo = new JwtSecurityToken(iaPEvent.data.signedRenewalInfo);

            switch (iaPEvent.notificationType)
            {
                case "CONSUMPTION_REQUEST":
                    break;
                case "DID_CHANGE_RENEWAL_PREF":
                    break;
                case "DID_CHANGE_RENEWAL_STATUS":
                    break;
                case "DID_FAIL_TO_RENEW":
                    break;
                case "DID_RENEW":
                    break;
                case "EXPIRED":
                    break;
                case "GRACE_PERIOD_EXPIRED":
                    break;
                case "OFFER_REDEEMED":
                    break;
                case "PRICE_INCREASE":
                    break;
                case "REFUND":
                    break;
                case "REFUND_DECLINED":
                    break;
                case "RENEWAL_EXTENDED":
                    break;
                case "REVOKE":
                    break;
                case "SUBSCRIBED":
                    break;
                default:
                    break;
            }

            return Ok(iaPEvent);
        }
    }
}