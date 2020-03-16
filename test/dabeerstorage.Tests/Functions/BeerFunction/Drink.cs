using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Core;
using AutoFixture.Xunit2;
using DaBeerStorage.Functions.Validators.ApiModels.Beer;
using Moq;
using Shouldly;
using Xunit;

namespace DaBeerStorage.Tests.Functions.BeerFunction
{
    public class Drink : BeerFunctionTest
    {
        public Drink() : base()
        {
            
        }
        [Fact]
        public void ShouldReturnBadRequest_WhenRequestIsNull() =>
            ReturnBadRequest_WhenRequestIsNull(mut.Drink).StatusCode.ShouldBe(BadRequest);
        
        [Fact]
        public void ShouldReturnBadRequest_WhenRequestModelIsNull() =>
            ReturnBadRequest_WhenModeInRequestIsNull(mut.Drink).StatusCode.ShouldBe(BadRequest);
        
        [Fact]
        public void Should_Call_CheckRequest()
        {
            var moqFunction = new Mock<DaBeerStorage.Functions.BeerFunction>() { CallBase = true};
         
            var actual = moqFunction.Object.Drink(It.IsAny<APIGatewayProxyRequest>(), It.IsAny<ILambdaContext>());

            moqFunction.Verify(x => x.CheckRequest<DaBeerStorage.Functions.ApiModels.Beer.Drink,DrinkValidator>(It.IsAny<APIGatewayProxyRequest>()),Times.Once);
        }
        
        [Theory,AutoData]
        public void Should_Return_Ok_When_Request_Is_Valid(DaBeerStorage.Functions.ApiModels.Beer.Drink objectTest)
        {
            Return_Ok_When_Request_Is_Valid<DaBeerStorage.Functions.ApiModels.Beer.Drink,DrinkValidator>(mut.Drink,objectTest);
        }

        [Theory,AutoData]
        public void Should_Return_ErrorList_When_Object_Has_Invalid_Data(DaBeerStorage.Functions.ApiModels.Beer.Drink objectTest)
        {
            objectTest.UserName = null;
            Return_BadRequest_WhenRequestIsValid<DaBeerStorage.Functions.ApiModels.Beer.Drink,DrinkValidator>(mut.Drink,objectTest);
        }
    }
}