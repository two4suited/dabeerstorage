using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Amazon.Lambda.Core;
using Microsoft.Extensions.Hosting;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace dabeerstorage.Functions
{
    public class Function
    {
        
        private readonly IHost _host;

        public Function(IHost host)
        {
            _host = host;
        }

        public Function() : this(Startup.Build()) { }
        
      
        public string FunctionHandler(string input, ILambdaContext context)
        {
            //var service = _host.Services.GetService<IConfigReader>();
            return input?.ToUpper();
        }
    }
}
