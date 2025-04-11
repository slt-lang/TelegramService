using Microsoft.AspNetCore.Mvc;
using sltlang.Common.TelegramService.Models;
using TelegramService.Domain;
using TelegramService.Domain.Ports;

namespace TelegramService.Controllers
{
    [ApiController]
    [Route("/")]
    public class TelegramController(ITelegramService telegramService) : ControllerBase
    {
        [HttpPost("log")]
        public async Task<IActionResult> SendLog([FromBody] TelegramMessage message)
        {
            await telegramService.SendLogMessage(message.CreateString());
            return Ok();
        }

        [HttpPost("alert")]
        public async Task<IActionResult> SendAlert([FromBody] TelegramMessage message)
        {
            await telegramService.SendAlertMessage(message.CreateString());
            return Ok();
        }
    }
}
