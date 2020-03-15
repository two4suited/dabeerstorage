using System.Collections.Generic;
using DaBeerStorage.Functions.Models;

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
        public static SearchViewModel FromCoreModel(Beer beer)
        {
            return new SearchViewModel()
            {
                Brewery = beer.BreweryName,
                Description = beer.Description,
                BeerName = beer.Name,
                LabelPath = beer.LabelPath,
                Ibu = beer.Ibu,
                Rating = beer.Rating,
                BreweryState = beer.BreweryState
            };
        }

        public static List<SearchViewModel> FromCoreModels(List<Beer> beers)
        {
            return null;
        }
    }
}