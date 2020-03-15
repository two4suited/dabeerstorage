using System.Collections.Generic;
using System.Linq;
using DaBeerStorage.Functions.Untappd.Models.BeerSearch;
using Beer = DaBeerStorage.Functions.Models.Beer;

namespace DaBeerStorage.Functions.ViewModels
{
    public class SearchViewModel
    {
        public string BeerName { get; set; }
        public string Brewery { get; set; }
        public string Description { get; set; }
        public string LabelPath { get; set; }
        public string Ibu { get; set; }
        public string Rating { get; set; }
        public string BreweryState { get; set; }
        public static SearchViewModel FromItemModel(Item searchResult)
        {
            return new SearchViewModel()
            {
                Brewery = searchResult.Brewery.BreweryName,
                Description = searchResult.Beer.BeerDescription,
                BeerName = searchResult.Beer.BeerName,
                LabelPath =searchResult.Beer.BeerLabel,
                Ibu = searchResult.Beer.BeerIbu.ToString(),
                Rating = searchResult.Beer.AuthRating.ToString(),
                BreweryState = searchResult.Brewery.Location.BreweryState
            };
        }

        public static SearchViewModel FromBeerModel(DaBeerStorage.Functions.Untappd.Models.BeerInfo.Beer beer)
        {
            return null;
        }

        public static List<SearchViewModel> FromItemModels(IList<Item> rows)
        {
            return rows.Select(SearchViewModel.FromItemModel).ToList();
        }
    }
}