using System.Threading.Tasks;
using DaBeerStorage.Functions.Untappd.Models.BeerSearch;
using Refit;
using Beer = DaBeerStorage.Functions.Untappd.Models.BeerInfo.Beer;

namespace DaBeerStorage.Functions.Interfaces
{
    public interface IUntappdApi
    {
        [Get("/search/beer?client_id={clientid}&client_secret={clientsecret}&q={q}")]
        Task<BeerSearch> GetBeerSearchAsync([AliasAs("clientid")] string clientId, [AliasAs("clientsecret")] string clientSecret,[AliasAs("q")] string searchStringy);

        [Get("/beer/info/{bid}?client_id={clientid}&client_secret={clientsecret}&compact=true")]
        Task<Beer> GetBeerById([AliasAs("clientid")] string clientId, [AliasAs("clientsecret")] string clientSecret,
            [AliasAs("bid")] string beerId);

    }
}
