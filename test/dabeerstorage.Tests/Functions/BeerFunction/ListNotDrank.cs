using Shouldly;
using Xunit;

namespace DaBeerStorage.Tests.Functions.BeerFunction
{
    public class ListNotDrank : BeerFunctionTest
    {
        public ListNotDrank() : base() { }
        
        [Fact]
        public void ShouldReturnBadRequest_WhenRequestIsNull() =>
            ReturnBadRequest_WhenRequestIsNull(mut.ListNotDrank).StatusCode.ShouldBe(BadRequest);
        
        [Fact]
        public void ShouldReturnBadRequest_WhenRequestModelIsNull() =>
            ReturnBadRequest_WhenModeInRequestIsNull(mut.ListNotDrank).StatusCode.ShouldBe(BadRequest);
    }
}