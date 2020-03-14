using System.Security.Cryptography;
using DaBeerStorage.Functions.Models;

namespace DaBeerStorage.Functions.ViewModels
{
    public class BeerViewModel
    {
        public string BeerName { get; set; }
        public string Location { get; set; }
        public static BeerViewModel FromCoreModel(Beer beer)
        {
            return new BeerViewModel()
            {
                BeerName = beer.Name,
                Location = beer.Location
            };
        }
    }
}