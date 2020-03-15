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
        }
    }
}