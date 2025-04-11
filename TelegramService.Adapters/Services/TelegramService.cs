using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types.ReplyMarkups;
using TelegramService.Domain;
using TelegramService.Domain.Ports;

namespace TelegramService.Adapters.Services
{
    public class TelegramService(Config config) : ITelegramService
    {
        public readonly TelegramBotClient telegramBotClient = new(config.BotSettings.Token);
        public readonly Random random = Random.Shared;

        public async Task SendAlertMessage(string message)
        {
            try
            {
                await Task.Delay(500 + random.Next(100, 500));
                await telegramBotClient.SendMessage(
                    chatId: config.BotSettings.AlertChannelId,
                    text: message
                );
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error sending message to channel: {ex.Message}");
            }
        }

        public async Task SendLogMessage(string message)
        {
            try
            {
                await Task.Delay(500 + random.Next(100, 500));
                await telegramBotClient.SendMessage(
                    chatId: config.BotSettings.LogChannelId,
                    text: message
                );
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error sending message to channel: {ex.Message}");
            }
        }
    }
}
