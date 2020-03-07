using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Core;
using Microsoft.Extensions.Hosting;

namespace DaBeerStorage.Functions
{
    public class LocationFunction : BaseFunction
    {

        public LocationFunction(IHost host) : base(host)
        {
        }

        public LocationFunction(){ }

        public APIGatewayProxyResponse Create(APIGatewayProxyRequest request, ILambdaContext context)
        {
            return null;
        }

        public APIGatewayProxyResponse List(APIGatewayProxyRequest request, ILambdaContext context)
        {
            return null;
        }
    }
}