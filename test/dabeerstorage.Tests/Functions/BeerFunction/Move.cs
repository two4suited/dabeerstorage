using Shouldly;
using Xunit;

namespace DaBeerStorage.Tests.Functions.BeerFunction
{
    public class Move : BeerFunctionTest
    {
        public Move() : base() { }
        
        [Fact]
        public void ShouldReturnBadRequest_WhenRequestIsNull() =>
            ReturnBadRequest_WhenRequestIsNull(mut.Move).StatusCode.ShouldBe(BadRequest);
        
        [Fact]
        public void ShouldReturnBadRequest_WhenRequestModelIsNull() =>
            ReturnBadRequest_WhenModeInRequestIsNull(mut.Move).StatusCode.ShouldBe(BadRequest);
    }
}