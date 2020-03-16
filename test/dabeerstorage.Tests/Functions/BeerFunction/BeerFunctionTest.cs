using System;
using System.Net;
using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Core;
using Amazon.Lambda.TestUtilities;
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
        public BeerFunctionTest()
        {
            mut = new DaBeerStorage.Functions.BeerFunction(Host);
        }
        
        protected void ReturnOk_WhenRequestIsValid<T,TQ>(
            Func<APIGatewayProxyRequest, TestLambdaContext, APIGatewayProxyResponse> method,
            T objectToTest
        ) where TQ:AbstractValidator<T>,new()
        {
            IValidator<T> validator = new TQ();
            var request = new APIGatewayProxyRequest() {Body = JsonConvert.SerializeObject(objectToTest)};
            var moqFunction = new Mock<DaBeerStorage.Functions.BeerFunction>() {CallBase = true};
            var nullResponse =
                moqFunction.Setup(x => x.CheckRequest(It.IsAny<APIGatewayProxyRequest>()))
                    .Returns((APIGatewayProxyResponse) null);
            moqFunction.Setup(x =>
                x.ValidateObject<T, TQ>(
                    It.IsAny<APIGatewayProxyRequest>())).Returns((APIGatewayProxyResponse) null);

            var actual = method(request, It.IsAny<TestLambdaContext>());

            actual.StatusCode.ShouldBe((int)HttpStatusCode.BadRequest);
            actual.Body.ShouldNotBeNull();

        }

        protected void Return_Ok_When_Request_Is_Valid<T,TQ>(Func<APIGatewayProxyRequest, TestLambdaContext, APIGatewayProxyResponse> method,
            T objectToTest
        ) where TQ:AbstractValidator<T>,new()
        {
            var request = new APIGatewayProxyRequest() {Body = JsonConvert.SerializeObject(objectToTest)};
            var moqFunction = new Mock<DaBeerStorage.Functions.BeerFunction>() { CallBase = true};
            var nullResponse = 
                moqFunction.Setup(x => x.CheckRequest(It.IsAny<APIGatewayProxyRequest>())).Returns((APIGatewayProxyResponse)null);
            moqFunction.Setup(x => x.ValidateObject<T,TQ>(It.IsAny<APIGatewayProxyRequest>())).Returns((APIGatewayProxyResponse)null);
         
            var actual = method(request, It.IsAny<TestLambdaContext>());

            actual.StatusCode.ShouldBe((int)HttpStatusCode.OK);
        }
    }
}