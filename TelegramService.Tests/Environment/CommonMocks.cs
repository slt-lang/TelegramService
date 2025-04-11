using TelegramService.Adapters.Database;
using TelegramService.Domain;
using TelegramService.Domain.Logic;
using TelegramService.Domain.Ports;
using Microsoft.Extensions.Caching.Memory;

namespace TelegramService.Tests.Environment
{
    public static class CommonMocks
    {
        public static IDateTime DateTimeProvider = new DateTimeProvider();
        public static ITelegramDb AuthDb => new TelegramDb(DateTimeProvider, MemoryCache, TelegramContext, Config);
        public static TelegramServiceContext TelegramContext => Extensions.GetInMemoryOptions<TelegramServiceContext>().GetTelegramServiceContext();
        public static Config Config => new()
        {

        };

        public static readonly IMemoryCache MemoryCache = new MemoryCache(new MemoryCacheOptions());
    }
}
