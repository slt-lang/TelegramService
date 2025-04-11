﻿using TelegramService.Domain.Ports;

namespace TelegramService.Domain.Logic
{
    public class DateTimeProvider : IDateTime
    {
        public DateTime Now => DateTime.Now;
        public DateTime UtcNow => DateTime.UtcNow;
        public DateTime Today => DateTime.Today;
        public DateTime UtcToday => DateTime.Today.ToUniversalTime();
    }
}
