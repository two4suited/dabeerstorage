using System.Collections.Generic;
using AutoFixture.Xunit2;
using DaBeerStorage.Functions.Models;
using DaBeerStorage.Functions.ViewModels;
using Shouldly;
using Xunit;

namespace DaBeerStorage.Tests.ViewModels
{
    public class SearchViewModelTest : BaseMappingTest
    {
        [Theory,AutoData]
        [Trait("Category","Mapping")]
        public void All_Properties_Should_Have_A_Value(Beer beer)
        {
            var viewModel = SearchViewModel.FromCoreModel(beer);

            VerifyMappings(viewModel);
        }
        
        [Theory, AutoData]
        public void AllPropertiesMap(Beer beer)
        {
            var viewModel = SearchViewModel.FromCoreModel(beer);
            viewModel.Brewery.ShouldBe(beer.BreweryName);
            viewModel.BeerName.ShouldBe(beer.Name);
            viewModel.Description.ShouldBe(beer.Description);
            viewModel.LabelPath.ShouldBe(beer.LabelPath);
            viewModel.Ibu.ShouldBe(beer.Ibu);
            viewModel.BreweryState.ShouldBe(beer.BreweryState);
            viewModel.Rating.ShouldBe(beer.Rating);
        }
        
        [Theory, AutoData]
        public void Should_MatchCount_WhenMapping_From_List(List<Beer> beers)
        {
            var viewModels = SearchViewModel.FromCoreModels(beers);
            
            beers.Count.ShouldBe(viewModels.Count);
        }
    }
}