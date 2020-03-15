using System.Collections.Generic;
using AutoFixture.Xunit2;
using DaBeerStorage.Functions.Untappd.Models.BeerSearch;
using DaBeerStorage.Functions.ViewModels;
using Shouldly;
using Xunit;
using Beer = DaBeerStorage.Functions.Models.Beer;

namespace DaBeerStorage.Tests.ViewModels
{
    public class SearchViewModelTest : BaseMappingTest
    {
        [Theory,AutoData]
        [Trait("Category","Mapping")]
        public void All_Properties_Should_Have_A_Value(Item searchResult)
        {
            var viewModel = SearchViewModel.FromItemModel(searchResult);

            VerifyMappings(viewModel);
        }
        
        [Theory,AutoData]
        [Trait("Category","Mapping")]
        public void Beer_All_Properties_Should_Have_A_Value(DaBeerStorage.Functions.Untappd.Models.BeerInfo.Beer beer)
        {
            var viewModel = SearchViewModel.FromBeerModel(beer);

            VerifyMappings(viewModel);
        }
        
        [Theory, AutoData]
        public void Beer_AllPropertiesMap(DaBeerStorage.Functions.Untappd.Models.BeerInfo.Beer beer)
        {
            var viewModel = SearchViewModel.FromBeerModel(beer);
            viewModel.Brewery.ShouldBe(beer.Brewery.BreweryName);
            viewModel.BeerName.ShouldBe(beer.BeerName);
            viewModel.Description.ShouldBe(beer.BeerDescription);
            viewModel.LabelPath.ShouldBe(beer.BeerLabel.AbsoluteUri);
            viewModel.Ibu.ShouldBe(beer.BeerIbu.ToString());
            viewModel.BreweryState.ShouldBe(beer.Brewery.Location.BreweryState);
            viewModel.Rating.ShouldBe(beer.AuthRating.ToString());
        }
        
        [Theory, AutoData]
        public void Item_AllPropertiesMap(Item searchResult)
        {
            var viewModel = SearchViewModel.FromItemModel(searchResult);
            viewModel.Brewery.ShouldBe(searchResult.Brewery.BreweryName);
            viewModel.BeerName.ShouldBe(searchResult.Beer.BeerName);
            viewModel.Description.ShouldBe(searchResult.Beer.BeerDescription);
            viewModel.LabelPath.ShouldBe(searchResult.Beer.BeerLabel);
            viewModel.Ibu.ShouldBe(searchResult.Beer.BeerIbu.ToString());
            viewModel.BreweryState.ShouldBe(searchResult.Brewery.Location.BreweryState);
            viewModel.Rating.ShouldBe(searchResult.Beer.AuthRating.ToString());
        }
        
        [Theory, AutoData]
        public void Should_MatchCount_WhenMapping_From_List(List<Item> searchResults)
        {
            var viewModels = SearchViewModel.FromItemModels(searchResults);
            
            searchResults.Count.ShouldBe(viewModels.Count);
        }
    }
}