using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using StoreFront.Models;

namespace StoreFront
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = BuildWebHost(args);

            using(var scope = host.Services.CreateScope()){

                var services = scope.ServiceProvider;

                try{
                    Seeds.Initialize(services);
                }
                catch(Exception exception){
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(exception, "The DB Could not be seeded");
                }

            }

            host.Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
