using System.Collections.Generic;
using System.Threading.Tasks;
using DaBeerStorage.Functions.ApiModels.Search;
using DaBeerStorage.Functions.ViewModels;

namespace DaBeerStorage.Functions.Interfaces
{
    public interface ISearchService
    {
        Task<List<SearchViewModel>> SearchByName(ByName name);
        Task<SearchViewModel>  SearchById(ById id);
    }
}