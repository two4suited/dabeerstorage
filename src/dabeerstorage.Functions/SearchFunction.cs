using Amazon.Lambda.Core;
using Microsoft.Extensions.Hosting;

namespace dabeerstorage.Functions
{
    public class SearchFunction : BaseFunction
    {
        public SearchFunction(IHost host) : base(host)
        {
        }
        
        public SearchFunction(){ }

        public string ByName(string input, ILambdaContext context)
        {
            return null;
        }
    }
}