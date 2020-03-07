using Amazon.CDK;
using Amazon.CDK.AWS.Lambda;

namespace dabeerstorage.Infrastructure
{
    public class InfrastructureStack : Stack
    {
        internal InfrastructureStack(Construct scope, string id, IStackProps props = null) : base(scope, id, props)
        {
            var createbeer = new Function(this,"createbeer", new FunctionProps() {
                Runtime = Runtime.DOTNET_CORE_2_1,
                FunctionName = "DaBeerStorage_CreateBeer",
                Timeout = Duration.Minutes(1),
                MemorySize = 128,
                Code = Code.FromAsset("src/databeerstorage.Functions/bin/Release/netcoreapp2.1/publish"),
                Handler = "dabeerstorage.Functions::dabeerstorage.Functions.Function::CreateBeer"
            });
        }
    }
}
