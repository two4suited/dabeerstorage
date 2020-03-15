using System.Reflection;
using AutoFixture.Xunit2;
using DaBeerStorage.Functions.Models;
using DaBeerStorage.Functions.ViewModels;
using Shouldly;
using Xunit;

namespace DaBeerStorage.Tests.ViewModels
{
    public class BeerViewModelTest : BaseMappingTest
    {
        [Trait("Category","Mapping")]
        [Theory,AutoData]
        public void All_Properties_Should_Have_A_Value(Beer beer)
        {
            var viewModel = BeerViewModel.FromCoreModel(beer);

            VerifyMappings(viewModel);
        }

        [Theory, AutoData]
        public void AllPropertiesMap(Beer beer)
        {
            var viewModel = BeerViewModel.FromCoreModel(beer);
            
            viewModel.Location.ShouldBe(beer.Location);
            viewModel.BeerName.ShouldBe(beer.Name);
            viewModel.Brewery.ShouldBe(beer.BreweryName);
            viewModel.LabelPath.ShouldBe(beer.LabelPath);
            viewModel.Style.ShouldBe(beer.Style);
            viewModel.BeerId.ShouldBe(beer.BeerId);
            viewModel.Ibu.ShouldBe(beer.Ibu);
            viewModel.BreweryState.ShouldBe(beer.BreweryState);
            viewModel.Rating.ShouldBe(beer.Rating);
           
        }

    }
}