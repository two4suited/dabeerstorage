using System;
using Xunit;
using Amazon.Lambda.TestUtilities;
using dabeerstorage.Functions;
using Microsoft.Extensions.Hosting;

namespace dabeerstorage.Tests
{
    public class FunctionTest
    {
        private IHost _host;
        private AppConfig _appConfig;
        public FunctionTest()
        {
            var host = new HostBuilder();

            /*
            _appConfig = new AppConfig()
            {
                FirstName = "Test",
                Lastname = "Class",
                Birthdate = DateTime.Today.AddYears(-10)
            };
                
            host.ConfigureServices((c, s) =>
            {
                s.Configure<CustomConfig>(options =>
                {
                    options.FirstName = _customConfig.FirstName;
                    options.Lastname = _customConfig.Lastname;
                    options.Birthdate = _customConfig.Birthdate;
                });
                
                s.AddScoped<IConfigReader,ConfigReader>();
               
            });
            */
            _host= host.Build();
        }
        
        
        /*[Fact]
        public void TestToUpperFunction()
        {

            // Invoke the lambda function and confirm the string was upper cased.
            var function = new Function();
            var context = new TestLambdaContext();
            var upperCase = function.FunctionHandler("hello world", context);

            Assert.Equal("HELLO WORLD", upperCase);
        }*/
    }
}
