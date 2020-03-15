using DaBeerStorage.Functions.Models;

namespace DaBeerStorage.Functions.ViewModels
{
    public class SearchViewModel
    {
        public string BeerName { get; set; }
        public string Brewery { get; set; }
        public string Description { get; set; }
        public string LabelPath { get; set; }
        public static SearchViewModel FromCoreModel(Beer beer)
        {
            return new SearchViewModel()
            {
                Brewery = beer.BreweryName,
                Description = beer.Description,
                BeerName = beer.Name,
                LabelPath = beer.LabelPath
            };
        }
    }
}