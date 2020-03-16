using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using DaBeerStorage.Functions.ApiModels.Beer;
using DaBeerStorage.Functions.Config;
using DaBeerStorage.Functions.Validators.ApiModels.Beer;
using FluentValidation;
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
                
                s.AddDefaultAWSOptions(c.Configuration.GetAWSOptions());
                s.AddAWSService<IAmazonDynamoDB>();
                s.AddTransient<IDynamoDBContext, DynamoDBContext>();
                s.AddTransient<IValidator<Create>,CreateValidator>();

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