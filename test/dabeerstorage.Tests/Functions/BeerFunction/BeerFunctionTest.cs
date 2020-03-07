namespace DaBeerStorage.Tests.Functions.BeerFunction
{
    public class BeerFunctionTest : BaseFunctionTest
    {
        protected DaBeerStorage.Functions.BeerFunction fut;
        public BeerFunctionTest()
        {
            fut = new DaBeerStorage.Functions.BeerFunction(Host);
        }
    }
}