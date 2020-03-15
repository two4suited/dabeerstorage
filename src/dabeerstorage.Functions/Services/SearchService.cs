using System.Collections.Generic;
using System.Threading.Tasks;
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
        public async  Task<List<SearchViewModel>>  SearchByName(ByName byName)
        {
            var results = await _repository.SearchByName(1, byName.SearchValue);
            return null;
        }

        public async  Task<List<SearchViewModel>>  SearchById(ById byId)
        {
            var results = await _repository.SearchById(byId.Id);
            return null;
        }
    }
}