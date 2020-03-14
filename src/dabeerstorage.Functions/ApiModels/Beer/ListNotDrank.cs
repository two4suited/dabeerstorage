using System.Collections.Generic;
using DaBeerStorage.Functions.ViewModels;

namespace DaBeerStorage.Functions.ApiModels.Beer
{
    public class ListNotDrank
    {
        public string UserName { get; set; }
        public string Location { get; set; }

        public List<BeerViewModel> Beers { get; set; }
    }
}