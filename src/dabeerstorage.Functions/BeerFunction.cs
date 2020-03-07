using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Core;
using DaBeerStorage.Functions.ApiModels.Beer;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.


namespace DaBeerStorage.Functions
{
    public class BeerFunction : BaseFunction
    {

        public BeerFunction(IHost host) : base(host){ }

        public BeerFunction() { }
        
      
        public APIGatewayProxyResponse Create(APIGatewayProxyRequest request, ILambdaContext context)
        {
            return CheckRequest(request) ?? null;
        }
        public APIGatewayProxyResponse Drink(APIGatewayProxyRequest request,ILambdaContext context)
        {
            return CheckRequest(request) ?? null;
        }
        
        public APIGatewayProxyResponse ListNotDrank(APIGatewayProxyRequest request, ILambdaContext context)
        {
            return CheckRequest(request) ?? null;    
        }
         public APIGatewayProxyResponse Move(APIGatewayProxyRequest request, ILambdaContext context)
         {
             return CheckRequest(request) ?? null;    
         }
    }
}
