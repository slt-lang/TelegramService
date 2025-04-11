using Microsoft.AspNetCore.Mvc;
using TelegramService.Domain.Ports;

namespace TelegramService.Controllers
{
    [ApiController]
    [Route("/")]
    public class TelegramController(ITelegramService telegramService) : ControllerBase
    {
        [HttpPost("log")]
        public async Task<IActionResult> SendLog(string message)
        {
            await telegramService.SendLogMessage(message);
            return Ok();
        }

        [HttpPost("alert")]
        public async Task<IActionResult> SendAlert(string message)
        {
            await telegramService.SendAlertMessage(message);
            return Ok();
        }
    }
}
