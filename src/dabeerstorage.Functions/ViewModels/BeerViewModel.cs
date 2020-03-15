using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using DaBeerStorage.Functions.Models;

namespace DaBeerStorage.Functions.ViewModels
{
    public class BeerViewModel
    {
        public string BeerName { get; set; }
        public string Location { get; set; }
        public string LabelPath { get; set; }
        public string Style { get; set; }
        public string Brewery { get; set; }
        public string BeerId { get; set; }

        public string Ibu { get; set; }
        public string Rating { get; set; }
        public string BreweryState { get; set; }
        public static BeerViewModel FromCoreModel(Beer beer)
        {
            return new BeerViewModel()
            {
                BeerName = beer.Name,
                Location = beer.Location,
                Brewery = beer.BreweryName,
                Style = beer.Style,
                BeerId = beer.BeerId,
                LabelPath = beer.LabelPath,
                Ibu = beer.Ibu,
                Rating = beer.Rating,
                BreweryState = beer.BreweryState
            };
        }

        public static List<BeerViewModel> FromCoreModels(IEnumerable<Beer> rows)
        {
            return rows.Select(BeerViewModel.FromCoreModel).ToList();
        }
    }
}