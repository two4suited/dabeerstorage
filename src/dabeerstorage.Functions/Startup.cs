using DaBeerStorage.Functions.Config;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace DaBeerStorage.Functions
{
    public class Startup
    {
        public static IHost Build()
        {
            var host = new HostBuilder();

            host.ConfigureAppConfiguration(c =>
            {
                c.AddJsonFile("appsettings.json", optional: true);
                c.AddEnvironmentVariables();
                /*
                c.AddSystemsManager(configureSource =>
                {
                    configureSource.Path = "/parameterstoredemo";
                    configureSource.Optional = false;
                });
                */
            });

            host.ConfigureServices((c, s) =>
            {
                s.Configure<AppConfig>(c.Configuration);

                s.AddLogging(x =>
                {
                    x.AddConsole();
                    x.AddAWSProvider();
                    x.SetMinimumLevel(LogLevel.Information);
                });
            });

            return host.Build();
        }
    }
}