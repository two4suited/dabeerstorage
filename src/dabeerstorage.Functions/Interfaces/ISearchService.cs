using System.Collections.Generic;
using DaBeerStorage.Functions.ApiModels.Search;
using DaBeerStorage.Functions.ViewModels;

namespace DaBeerStorage.Functions.Interfaces
{
    public interface ISearchService
    {
        List<SearchViewModel> SearchByName(ByName name);
        List<SearchViewModel>  SearchById(ById id);
    }
}