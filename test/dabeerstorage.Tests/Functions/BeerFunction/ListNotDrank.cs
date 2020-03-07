using Shouldly;
using Xunit;

namespace DaBeerStorage.Tests.Functions.BeerFunction
{
    public class ListNotDrank : BeerFunctionTest
    {
        public ListNotDrank() : base() { }
        
        [Fact]
        public void ShouldReturnBadRequest_WhenRequestIsNull() =>
            ReturnBadRequest_WhenRequestIsNull(fut.ListNotDrank).StatusCode.ShouldBe(BadRequest);
    }
}