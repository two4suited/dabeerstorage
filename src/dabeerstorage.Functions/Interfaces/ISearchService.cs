using DaBeerStorage.Functions.ApiModels.Search;

namespace DaBeerStorage.Functions.Interfaces
{
    public interface ISearchService
    {
        BeerList SearchByName(ByName name);
        BeerList SearchById(ById id);
    }
}