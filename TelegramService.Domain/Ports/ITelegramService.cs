namespace TelegramService.Domain.Ports
{
    public interface ITelegramService
    {
        Task SendAlertMessage(string message);
        Task SendLogMessage(string message);
    }
}
