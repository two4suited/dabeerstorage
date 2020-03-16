using System.Net;
using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Core;
using Amazon.Lambda.TestUtilities;
using AutoFixture.Xunit2;
using DaBeerStorage.Functions;
using DaBeerStorage.Functions.Interfaces;
using DaBeerStorage.Functions.Validators.ApiModels.Beer;
using FluentValidation.Results;
using Moq;
using Newtonsoft.Json;
using Shouldly;
using Xunit;

namespace DaBeerStorage.Tests.Functions.BeerFunction
{
    public class Create : BeerFunctionTest
    {
        public Create() : base() { }

        [Fact]
        public void ShouldReturnBadRequest_WhenRequestIsNull() =>
            ReturnBadRequest_WhenRequestIsNull(mut.Create).StatusCode.ShouldBe(BadRequest);

        [Fact]
        public void ShouldReturnBadRequest_WhenRequestModelIsNull() =>
            ReturnBadRequest_WhenModeInRequestIsNull(mut.Create).StatusCode.ShouldBe(BadRequest);

        [Fact]
        public void Should_Call_CheckRequest()
        {
            var moqFunction = new Mock<DaBeerStorage.Functions.BeerFunction>() { CallBase = true};
         
            var actual = moqFunction.Object.Create(It.IsAny<APIGatewayProxyRequest>(), It.IsAny<ILambdaContext>());

            moqFunction.Verify(x => x.CheckRequest<DaBeerStorage.Functions.ApiModels.Beer.Create,CreateValidator>(It.IsAny<APIGatewayProxyRequest>()),Times.Once);
        }
        
        [Theory,AutoData]
        public void Should_Return_Ok_When_Request_Is_Valid(DaBeerStorage.Functions.ApiModels.Beer.Create createObject)
        {
            Return_Ok_When_Request_Is_Valid<DaBeerStorage.Functions.ApiModels.Beer.Create,CreateValidator>(mut.Create,createObject);
        }

        [Theory,AutoData]
        public void Should_Return_ErrorList_When_Object_Has_Invalid_Data(DaBeerStorage.Functions.ApiModels.Beer.Create createObject)
        {
            createObject.Description = null;
            Return_BadRequest_WhenRequestIsValid<DaBeerStorage.Functions.ApiModels.Beer.Create,CreateValidator>(mut.Create,createObject);
        }
    }
}