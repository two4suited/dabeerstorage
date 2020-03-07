using Amazon.Lambda.Core;
using Microsoft.Extensions.Hosting;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.


namespace dabeerstorage.Functions
{
    public class BeerFunction : BaseFunction
    {

        public BeerFunction(IHost host) : base(host){ }

        public BeerFunction() { }
        
      
        public string Create(string input, ILambdaContext context)
        {
            //var service = Host.Services.GetService<IConfigReader>();
            return input?.ToUpper();
        }
        public string Drink(string input,ILambdaContext context)
        {
            return input;
        }
        
        public string ListNotDrank(string input, ILambdaContext context)
        {
            return null;     
        }
         public string Move(string input, ILambdaContext context)
         {
            return null;     
         }
    }
}
