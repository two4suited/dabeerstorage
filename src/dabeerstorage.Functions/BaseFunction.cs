
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Core;
using DaBeerStorage.Functions.ApiModels.Beer;
using DaBeerStorage.Functions.Interfaces;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]
namespace DaBeerStorage.Functions
{
    public  class BaseFunction 
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

        protected APIGatewayProxyResponse Ok(object model)
        {
            return new APIGatewayProxyResponse()
            {
                Body = JsonConvert.SerializeObject(model),
                StatusCode = (int) HttpStatusCode.OK,
                Headers = new Dictionary<string, string>
                { 
                    { "Content-Type", "application/json" }
                }
            };
        }

        public virtual APIGatewayProxyResponse ValidateObject<T,TQ>(APIGatewayProxyRequest request) where TQ:AbstractValidator<T>,new() 
        {
            
            IValidator<T> validator = new TQ();
            var createBody = JsonConvert.DeserializeObject<Create>(request.Body);
            var validationResults = validator.Validate(createBody);
            
            if (!validationResults.IsValid)
            {
                var sb = new StringBuilder();
                validationResults.Errors.ToList().ForEach(x => sb.Append(x));
                var combinedList = sb.ToString();

                return new APIGatewayProxyResponse()
                {

                    Body = JsonConvert.SerializeObject(combinedList),
                    StatusCode = (int) HttpStatusCode.BadRequest,
                    Headers = new Dictionary<string, string>
                    {
                        {"Content-Type", "application/json"}
                    }
                };
            }

            return null;
        }

        private APIGatewayProxyResponse NullModelRequest()
        {
            return new APIGatewayProxyResponse()
            {
                Body = "Your Json Payload is null",
                StatusCode = (int) HttpStatusCode.BadRequest,
                Headers = new Dictionary<string, string>
                { 
                    { "Content-Type", "application/json" }
                }
            };
        }

        public virtual APIGatewayProxyResponse CheckRequest(APIGatewayProxyRequest request)
        {
            if (request == null) return NullRequest();
            return request.Body == null ? NullModelRequest() : null;
        }
    }
}