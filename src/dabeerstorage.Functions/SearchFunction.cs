using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Core;
using Microsoft.Extensions.Hosting;

namespace DaBeerStorage.Functions
{
    public class SearchFunction : BaseFunction
    {
        public SearchFunction(IHost host) : base(host)
        {
        }
        
        public SearchFunction(){ }

        public APIGatewayProxyResponse ByName(APIGatewayProxyRequest request, ILambdaContext context)
        {
            return null;
        }
    }
}