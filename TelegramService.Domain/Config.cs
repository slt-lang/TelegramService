namespace TelegramService.Domain
{
    public class Config
    {
        public TelegramBotSettings BotSettings { get; set; } = default!;
        public string[] AllowedHosts { get; set; } = default!;
    }
}
