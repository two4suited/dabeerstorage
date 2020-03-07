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
    }
}