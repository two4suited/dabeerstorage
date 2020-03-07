
using System.Collections.Generic;
using System.Net;
using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Core;
using Microsoft.Extensions.Hosting;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]
namespace DaBeerStorage.Functions
{
    public class BaseFunction
    {
        protected readonly IHost Host;

        protected BaseFunction(IHost host) => Host = host;
      
        protected BaseFunction() : this(Startup.Build()) { }

        protected APIGatewayProxyResponse NullRequest()
        {
            return new APIGatewayProxyResponse()
            {
                Body = "Your Request can't be null",
                StatusCode = (int) HttpStatusCode.BadRequest,
                Headers = new Dictionary<string, string>
                { 
                    { "Content-Type", "application/json" }
                }
            };
        }
    }
}