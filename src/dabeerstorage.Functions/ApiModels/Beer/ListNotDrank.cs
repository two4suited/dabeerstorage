using System.Collections.Generic;

namespace DaBeerStorage.Functions.ApiModels.Beer
{
    public class ListNotDrank
    {
        public string UserName { get; set; }
        public List<Models.Beer> Beers { get; set; }
    }
}