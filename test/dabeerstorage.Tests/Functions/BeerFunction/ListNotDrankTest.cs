using AutoFixture.Xunit2;
using DaBeerStorage.Functions.ApiModels.Beer;
using DaBeerStorage.Functions.Validators.ApiModels.Beer;
using Shouldly;
using Xunit;

namespace DaBeerStorage.Tests.Functions.BeerFunction
{
    public class ListNotDrankTest : BeerFunctionTest
    {
        public ListNotDrankTest() : base() { }
        
        [Fact]
        public void ShouldReturnBadRequest_WhenRequestIsNull() =>
            ReturnBadRequest_WhenRequestIsNull(mut.ListNotDrank).StatusCode.ShouldBe(BadRequest);
        
        [Fact]
        public void ShouldReturnBadRequest_WhenRequestModelIsNull() =>
            ReturnBadRequest_WhenModeInRequestIsNull(mut.ListNotDrank).StatusCode.ShouldBe(BadRequest);

        [Fact]
        public void Should_Call_CheckRequest() => Call_CheckRequest<ListNotDrank,ListNotDrankValidator>(moqFunction.Object.Create);

        [Theory,AutoData]
        public void Should_Return_Ok_When_Request_Is_Valid(ListNotDrank objectTest)
        {
            Return_Ok_When_Request_Is_Valid<ListNotDrank,ListNotDrankValidator>(mut.ListNotDrank,objectTest);
        }

        [Theory,AutoData]
        public void Should_Return_ErrorList_When_Object_Has_Invalid_Data(ListNotDrank objectTest)
        {
            objectTest.Location = null;
            Return_BadRequest_WhenRequestIsValid<ListNotDrank,ListNotDrankValidator>(mut.Create,objectTest);
        }
        
    }
}