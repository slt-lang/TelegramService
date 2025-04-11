using TelegramService.Adapters.Database;
using TelegramService.Domain;
using TelegramService.Domain.Logic;
using TelegramService.Domain.Ports;
using Microsoft.EntityFrameworkCore;

namespace TelegramService
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //builder.Services.AddNpgsql<TelegramServiceContext>(builder.Configuration.GetConnectionString("TelegramDb"));
            //builder.Services.AddTransient<ITelegramDb, TelegramDb>();
            builder.Services.AddTransient<IDateTime, DateTimeProvider>();
            builder.Services.AddMemoryCache();

            var configuration = builder.Configuration.GetSection("Config").Get<Config>();
            builder.Services.AddSingleton(configuration ?? new());

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            //if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            //using (var scope = app.Services.CreateScope())
            //{
            //    var db = scope.ServiceProvider.GetRequiredService<TelegramServiceContext>();
            //    await db.Database.MigrateAsync();
            //}

            app.Run();
        }
    }
}
