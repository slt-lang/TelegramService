namespace TelegramService.Domain
{
    public class TelegramBotSettings
    {
        public string Token { get; set; } = default!;
        public string AlertChannelId { get; set; } = default!;
        public string LogChannelId { get; set; } = default!;
    }
}
