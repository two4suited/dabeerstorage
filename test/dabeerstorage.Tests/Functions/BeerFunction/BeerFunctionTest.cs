namespace DaBeerStorage.Tests.Functions.BeerFunction
{
    public class BeerFunctionTest : BaseFunctionTest
    {
        protected DaBeerStorage.Functions.BeerFunction mut;
        public BeerFunctionTest()
        {
            mut = new DaBeerStorage.Functions.BeerFunction(Host);
        }
    }
}