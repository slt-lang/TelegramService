using TelegramService.Adapters.Database;
using Microsoft.EntityFrameworkCore;

namespace TelegramService.Tests.Environment
{
    internal static class Extensions
    {
        public static TelegramServiceContext GetTelegramServiceContext(this DbContextOptions<TelegramServiceContext> options)
        {
            var context = new TelegramServiceContext(options);
            context.Database.EnsureCreated();
            context.Database.EnsureDeleted();
            return context;
        }

        public static DbContextOptions<T> GetInMemoryOptions<T>() where T : DbContext
        {
            return new DbContextOptionsBuilder<T>().UseInMemoryDatabase(databaseName: "Fake" + typeof(T).Name).Options;
        }
    }
}
