using Microsoft.EntityFrameworkCore;

namespace TelegramService.Adapters.Database
{
    public class TelegramServiceContext(DbContextOptions options) : DbContext(options)
    {
        public const string AuthScheme = "TelegramService";

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        private string DateTimeNowSqlFunction
        {
            get
            {
                if (Database.ProviderName == "Npgsql.EntityFrameworkCore.PostgreSQL")
                    return "NOW()";
                return "GETDATE()";
            }
        }
    }
}
