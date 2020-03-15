using System.Collections.Generic;
using DaBeerStorage.Functions.ApiModels.Search;
using DaBeerStorage.Functions.Interfaces;
using DaBeerStorage.Functions.ViewModels;

namespace DaBeerStorage.Functions.Services
{
    public class SearchService : ISearchService
    {
        private readonly IBeerSearchRepository _repository;

        public SearchService(IBeerSearchRepository repository)
        {
            _repository = repository;
        }
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