using Amazon.Lambda.Core;
using Microsoft.Extensions.Hosting;

namespace dabeerstorage.Functions
{
    public class LocationFunction : BaseFunction
    {

        public LocationFunction(IHost host) : base(host)
        {
        }

        public LocationFunction(){ }

        public string Create(string input, ILambdaContext context)
        {
            return null;
        }

        public string List(string input, ILambdaContext context)
        {
            return null;
        }
    }
}