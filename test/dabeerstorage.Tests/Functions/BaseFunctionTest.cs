using System;
using System.Net;
using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.TestUtilities;
using Microsoft.Extensions.Hosting;

namespace DaBeerStorage.Tests.Functions
{
    public class BaseFunctionTest
    {
        protected readonly TestLambdaContext Context;
        protected readonly IHost Host;

        protected int BadRequest => (int) HttpStatusCode.BadRequest;

        protected BaseFunctionTest()
        {
            var hostBuilder = new HostBuilder();
                
            hostBuilder.ConfigureServices((c, s) =>
                { });
            Host =  hostBuilder.Build();
            
            Context = new TestLambdaContext();
        }

        protected APIGatewayProxyResponse ReturnBadRequest_WhenRequestIsNull(
            Func<APIGatewayProxyRequest,TestLambdaContext, APIGatewayProxyResponse> method)
        {
            return method(null,Context);
        }
    }
}