using System.Collections.Generic;
using DaBeerStorage.Functions.ViewModels;

namespace DaBeerStorage.Functions.ApiModels.Search
{
    public class ByName
    {
        public string SearchValue { get; set; }
        public List<SearchViewModel> SearchResults { get; set; }
    }
}