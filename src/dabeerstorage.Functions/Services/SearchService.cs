using System.Collections.Generic;
using DaBeerStorage.Functions.ApiModels.Search;
using DaBeerStorage.Functions.Interfaces;
using DaBeerStorage.Functions.ViewModels;

namespace DaBeerStorage.Functions.Services
{
    public class SearchService : ISearchService
    {
        public  List<SearchViewModel>  SearchByName(ByName name)
        {
            throw new System.NotImplementedException();
        }

        public  List<SearchViewModel>  SearchById(ById id)
        {
            throw new System.NotImplementedException();
        }
    }
}