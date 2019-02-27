using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using Microsoft.EntityFrameworkCore;
using helloasp.Models;

namespace helloasp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateWebHostBuilder(args).Build();

            using(var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                     services
                        .GetRequiredService<helloaspContext>()
                        .Database.Migrate();
                    
                }catch(Exception ex)
                {
                    services
                        .GetRequiredService<ILogger<Program>>()
                        .LogError(ex, "An error occurred seeding the DB.");
                }
                host.Run();
            }
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
