
using Amazon.Lambda.Core;
using Microsoft.Extensions.Hosting;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]
namespace dabeerstorage.Functions
{
    public class BaseFunction
    {
        protected readonly IHost Host;

        protected BaseFunction(IHost host)
        {
            Host = host;
        }

        protected BaseFunction() : this(Startup.Build())
        {
            
        }
    }
}