using Amazon.CDK;
using Amazon.CDK.AWS.Lambda;

namespace dabeerstorage.Infrastructure
{
    public class InfrastructureStack : Stack
    {
        internal InfrastructureStack(Construct scope, string id, IStackProps props = null) : base(scope, id, props)
        {
            CreateFunction("CreateBeer");
           
        }

        private void CreateFunction(string methodName)
        {
            var pathToPublishFolder = "../src/dabeerstorage.Functions/bin/Release/netcoreapp2.1/publish";
            var functionClass = "dabeerstorage.Functions::dabeerstorage.Functions.Function::";
            
            var createbeer = new Function(this,"createbeer", new FunctionProps() {
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
