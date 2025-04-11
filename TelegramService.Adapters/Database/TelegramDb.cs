using TelegramService.Domain;
using TelegramService.Domain.Ports;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;

namespace TelegramService.Adapters.Database
{
    public class TelegramDb(IDateTime dateTime, IMemoryCache memoryCache, TelegramServiceContext db, Config config) : ITelegramDb
    {

    }
}
