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
            ReturnBadRequest_WhenRequestIsNull(fut.Drink).StatusCode.ShouldBe(BadRequest);
    }
}