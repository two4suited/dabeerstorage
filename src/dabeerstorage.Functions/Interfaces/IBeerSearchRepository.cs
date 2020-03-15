using System.Collections.Generic;
using System.Threading.Tasks;
using DaBeerStorage.Functions.Untappd.Models.BeerSearch;
using Beer = DaBeerStorage.Functions.Untappd.Models.BeerInfo.Beer;

namespace DaBeerStorage.Functions.Interfaces
{
    public interface IBeerSearchRepository
    {
        Task<IList<Item>> SearchByName(int page,string searchString);
        Task<Beer> SearchById(string beerId);
    }
}
