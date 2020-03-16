using AutoFixture.Xunit2;
using DaBeerStorage.Functions.ApiModels.Beer;
using DaBeerStorage.Functions.Validators.ApiModels.Beer;
using Shouldly;
using Xunit;

namespace DaBeerStorage.Tests.Functions.BeerFunction
{
    public class MoveTest : BeerFunctionTest
    {
        public MoveTest() : base() { }
        
        [Fact]
        public void ShouldReturnBadRequest_WhenRequestIsNull() =>
            ReturnBadRequest_WhenRequestIsNull(mut.Move).StatusCode.ShouldBe(BadRequest);
        
        [Fact]
        public void ShouldReturnBadRequest_WhenRequestModelIsNull() =>
            ReturnBadRequest_WhenModeInRequestIsNull(mut.Move).StatusCode.ShouldBe(BadRequest);
        
        [Fact]
        public void Should_Call_CheckRequest() => Call_CheckRequest<Move,MoveValidator>(moqFunction.Object.Move);

        [Theory,AutoData]
        public void Should_Return_Ok_When_Request_Is_Valid(Move objectTest)
        {
            Return_Ok_When_Request_Is_Valid<Move,MoveValidator>(mut.Move,objectTest);
        }

        [Theory,AutoData]
        public void Should_Return_ErrorList_When_Object_Has_Invalid_Data(Move objectTest)
        {
            objectTest.BeerId = null;
            Return_BadRequest_WhenRequestIsValid<Move,MoveValidator>(mut.Move,objectTest);
        }
    }
}