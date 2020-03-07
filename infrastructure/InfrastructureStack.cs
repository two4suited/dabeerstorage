using Amazon.CDK;
using Amazon.CDK.AWS.APIGateway;
using Amazon.CDK.AWS.Lambda;
using Resource = Amazon.CDK.AWS.APIGateway.Resource;

namespace dabeerstorage.Infrastructure
{
    public class InfrastructureStack : Stack
    {
        internal InfrastructureStack(Construct scope, string id, IStackProps props = null) : base(scope, id, props)
        {
            var api = CreateApi("DaBeerStorage");
        
            var beerResource = CreateResource("beer",api);
            
            AddMethod("Post",CreateFunction("CreateBeer","Beer"),beerResource);
            
            AddMethod("Post",CreateFunction("Drink","Beer"),AddResource("drink",beerResource));
            
            AddMethod("Get",CreateFunction("ListNotDrank","Beer"),AddResource("notdrank",beerResource));
            
            AddMethod("Post",CreateFunction("Move","Beer"),AddResource("move",beerResource));
        }

        private RestApi CreateApi(string name)
        {
            return new RestApi(this, name.ToLower(), new RestApiProps()
            {
                RestApiName = name
            });
        }

        private Resource AddResource(string path,Resource resource)
        {
            return resource.AddResource(path);
        }

        private Resource CreateResource(string path,RestApi api)
        {
            return api.Root.AddResource(path);
        }

        private void AddMethod(string httpMethod, Function function, Resource apiGatewayResource)
        {
            var integration = new LambdaIntegration(function);
            apiGatewayResource.AddMethod(httpMethod, integration);
        }
        
        private Function CreateFunction(string methodName,string functionName)
        {
            var pathToPublishFolder = "../src/dabeerstorage.Functions/bin/Release/netcoreapp2.1/publish";
            var functionClass = $"dabeerstorage.Functions::dabeerstorage.Functions.{functionName}::";
            
            return new Function(this,methodName.ToLower(), new FunctionProps() {
                Runtime = Runtime.DOTNET_CORE_2_1,
                FunctionName = $"DaBeerStorage_{methodName}",
                Timeout = Duration.Minutes(1),
                MemorySize = 128,
                Code = Code.FromAsset(pathToPublishFolder),
                Handler = $"{functionClass}{methodName}"
            });
        }
    }
}
