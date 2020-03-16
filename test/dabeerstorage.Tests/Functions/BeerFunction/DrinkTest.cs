using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Core;
using AutoFixture.Xunit2;
using DaBeerStorage.Functions.ApiModels.Beer;
using DaBeerStorage.Functions.Validators.ApiModels.Beer;
using Moq;
using Shouldly;
using Xunit;

namespace DaBeerStorage.Tests.Functions.BeerFunction
{
    public class DrinkTest : BeerFunctionTest
    {
        public DrinkTest() : base()
        {
            
        }
        [Fact]
        public void ShouldReturnBadRequest_WhenRequestIsNull() =>
            ReturnBadRequest_WhenRequestIsNull(mut.Drink).StatusCode.ShouldBe(BadRequest);
        
        [Fact]
        public void ShouldReturnBadRequest_WhenRequestModelIsNull() =>
            ReturnBadRequest_WhenModeInRequestIsNull(mut.Drink).StatusCode.ShouldBe(BadRequest);

        [Fact]
        public void Should_Call_CheckRequest() => Call_CheckRequest<Drink,DrinkValidator>(moqFunction.Object.Drink);

        [Theory,AutoData]
        public void Should_Return_Ok_When_Request_Is_Valid(Drink objectTest)
        {
            Return_Ok_When_Request_Is_Valid<Drink,DrinkValidator>(mut.Drink,objectTest);
        }

        [Theory,AutoData]
        public void Should_Return_ErrorList_When_Object_Has_Invalid_Data(Drink objectTest)
        {
            objectTest.UserName = null;
            Return_BadRequest_WhenRequestIsValid<Drink,DrinkValidator>(mut.Drink,objectTest);
        }
    }
}