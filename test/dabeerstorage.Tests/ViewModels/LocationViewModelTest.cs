using AutoFixture.Xunit2;
using DaBeerStorage.Functions.Models;
using DaBeerStorage.Functions.ViewModels;
using Shouldly;
using Xunit;

namespace DaBeerStorage.Tests.ViewModels
{
    public class LocationViewModelTest : BaseMappingTest
    {
        [Theory,AutoData]
        [Trait("Category","Mapping")]
        public void All_Properties_Should_Have_A_Value(Location location)
        {
            var viewModel = LocationViewModel.FromCoreModel(location);

            VerifyMappings(viewModel);
        }
        
        [Theory, AutoData]
        public void AllPropertiesMap(Location location)
        {
            var viewModel = LocationViewModel.FromCoreModel(location);
            viewModel.Name.ShouldBe(location.Name);
        }
    }
}