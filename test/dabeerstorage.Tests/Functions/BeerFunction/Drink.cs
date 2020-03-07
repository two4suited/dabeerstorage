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
    }
}