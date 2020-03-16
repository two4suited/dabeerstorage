using System;
using System.Net;
using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Core;
using Amazon.Lambda.TestUtilities;
using DaBeerStorage.Functions.Data;
using DaBeerStorage.Functions.Validators.ApiModels.Beer;
using FluentValidation;
using Moq;
using Newtonsoft.Json;
using Shouldly;

namespace DaBeerStorage.Tests.Functions.BeerFunction
{
    public class BeerFunctionTest : BaseFunctionTest
    {
        protected DaBeerStorage.Functions.BeerFunction mut;
        protected new Mock<DaBeerStorage.Functions.BeerFunction> moqFunction; 
        public BeerFunctionTest()
        {
            mut = new DaBeerStorage.Functions.BeerFunction(Host);
            moqFunction = new Mock<DaBeerStorage.Functions.BeerFunction>() { CallBase = true};
        }
        
        protected void Return_BadRequest_WhenRequestIsValid<T,TQ>(
            Func<APIGatewayProxyRequest, TestLambdaContext, APIGatewayProxyResponse> method,
            T objectToTest
        ) where TQ:AbstractValidator<T>,new()
        {
            IValidator<T> validator = new TQ();
            var request = new APIGatewayProxyRequest() {Body = JsonConvert.SerializeObject(objectToTest)};
            var moqFunction = new Mock<DaBeerStorage.Functions.BeerFunction>() {CallBase = true};
            var nullResponse =
                moqFunction.Setup(x => x.CheckRequest<T,TQ>(It.IsAny<APIGatewayProxyRequest>()))
                    .Returns((APIGatewayProxyResponse) null);
           

            var actual = method(request, It.IsAny<TestLambdaContext>());
            
            actual.Body.ShouldContain("Object is invalid");

        }
        
        public void Call_CheckRequest<T,TQ>( Func<APIGatewayProxyRequest, TestLambdaContext, APIGatewayProxyResponse> method
        ) where TQ:AbstractValidator<T>,new()
        {
            var actual = method(It.IsAny<APIGatewayProxyRequest>(), It.IsAny<TestLambdaContext>());

            moqFunction.Verify(x => x.CheckRequest<T,TQ>(It.IsAny<APIGatewayProxyRequest>()),Times.Once);
        }

        protected void Return_Ok_When_Request_Is_Valid<T,TQ>(Func<APIGatewayProxyRequest, TestLambdaContext, APIGatewayProxyResponse> method,
            T objectToTest
        ) where TQ:AbstractValidator<T>,new()
        {
            var request = new APIGatewayProxyRequest() {Body = JsonConvert.SerializeObject(objectToTest)};
            var moqFunction = new Mock<DaBeerStorage.Functions.BeerFunction>() { CallBase = true};
            var nullResponse = 
                moqFunction.Setup(x => x.CheckRequest<T,TQ>(It.IsAny<APIGatewayProxyRequest>())).Returns((APIGatewayProxyResponse)null);
       
            var actual = method(request, It.IsAny<TestLambdaContext>());

            actual.StatusCode.ShouldBe((int)HttpStatusCode.OK);
        }
    }
}