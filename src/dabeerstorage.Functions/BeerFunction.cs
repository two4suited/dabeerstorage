using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Core;
using Microsoft.Extensions.Hosting;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.


namespace DaBeerStorage.Functions
{
    public class BeerFunction : BaseFunction
    {

        public BeerFunction(IHost host) : base(host){ }

        public BeerFunction() { }
        
      
        public APIGatewayProxyResponse Create(APIGatewayProxyRequest request, ILambdaContext context)
        {
            if (request == null) return NullRequest();

            return null;
        }
        public APIGatewayProxyResponse Drink(APIGatewayProxyRequest request,ILambdaContext context)
        {
            if (request == null) return NullRequest();

            return null;
        }
        
        public APIGatewayProxyResponse ListNotDrank(APIGatewayProxyRequest request, ILambdaContext context)
        {
            if (request == null) return NullRequest();
            
            return null;     
        }
         public APIGatewayProxyResponse Move(APIGatewayProxyRequest request, ILambdaContext context)
         {
             if (request == null) return NullRequest();
             
            return null;     
         }
    }
}
