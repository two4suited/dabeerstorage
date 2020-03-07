using System.Collections.Generic;
using System.Threading.Tasks;
using DaBeerStorage.Functions.Config;
using DaBeerStorage.Functions.Interfaces;
using DaBeerStorage.Functions.Untappd.Models.BeerSearch;
using Refit;
using Beer = DaBeerStorage.Functions.Untappd.Models.BeerInfo.Beer;

namespace DaBeerStorage.Functions.Untappd
{
    public class UntappdRepository : IBeerSearchRepository
    {
        private readonly UntappdApiOptions _options;
        private readonly IUntappdApi _client;

        public UntappdRepository(UntappdApiOptions options)
        {
            _options = options;
            _client = RestService.For<IUntappdApi>(_options.Url);
        }
        public async Task<IList<Item>> SearchByName(int page, string beerName)
        {
            var response = await _client.GetBeerSearchAsync(_options.ClientId, _options.ClientKey, beerName);

            return response.Response.Beers.Items;

        }

        public async Task<Beer> SearchById(int beerId)
        {
            var response = await _client.GetBeerById(_options.ClientId, _options.ClientKey, beerId);
            return response;
        }
    }
}
