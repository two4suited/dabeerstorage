using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Core;
using DaBeerStorage.Functions.ApiModels.Beer;
using DaBeerStorage.Functions.Validators.ApiModels.Beer;
using FluentValidation;
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
            var check = CheckRequest<Create,CreateValidator>(request);

            if (check != null) return check;
           
            return Ok(request.Body);

        }
        public APIGatewayProxyResponse Drink(APIGatewayProxyRequest request,ILambdaContext context)
        {
            return CheckRequest<Drink,DrinkValidator>(request) ?? null;
        }
        
        public APIGatewayProxyResponse ListNotDrank(APIGatewayProxyRequest request, ILambdaContext context)
        {
            return request == null ? NullRequest() : null; 
        }
         public APIGatewayProxyResponse Move(APIGatewayProxyRequest request, ILambdaContext context)
         {
             return CheckRequest<Move,MoveValidator>(request) ?? null;    
         }
    }
}
