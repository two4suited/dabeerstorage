using AutoFixture.Xunit2;
using DaBeerStorage.Functions.ApiModels.Location;
using DaBeerStorage.Functions.Validators.ApiModels.Location;
using DaBeerStorage.Functions.ViewModels;
using DaBeerStorage.Tests.ViewModels;
using FluentValidation.TestHelper;
using Shouldly;
using Xunit;

namespace DaBeerStorage.Tests.ApiModels.Location
{
    public class AddTest : BaseMappingTest
    {
        private readonly AddValidator _validator;
        public AddTest()
        {
            _validator = new AddValidator();
        }
        
        [Trait("Category","Mapping")]
        [Theory,AutoData]
        public void All_Properties_Should_Have_A_Value(Add newLocation)
        {
            var coreModel = newLocation.ToCoreModel();

            VerifyMappings(newLocation);
        }

        [Theory, AutoData]
        public void AllPropertiesMap(Add newLocation)
        {
            var coreModel = newLocation.ToCoreModel();
            
            coreModel.Name.ShouldBe(newLocation.Name);
        }
        
        [Fact]
        public void ShouldHaveValidationError_When_Name_IsNull()
        {
            _validator.ShouldHaveValidationErrorFor(c => c.Name, null as string);
        }

        [Fact]
        public void ShouldHaveValidationError_When_Name_Is_EmptyString()
        {
            _validator.ShouldHaveValidationErrorFor(c => c.Name, "");
        }
        [Fact]
        public void ShouldHaveValidationError_When_UserName_IsNull()
        {
            _validator.ShouldHaveValidationErrorFor(c => c.UserName, null as string);
        }

        [Fact]
        public void ShouldHaveValidationError_When_UserName_Is_EmptyString()
        {
            _validator.ShouldHaveValidationErrorFor(c => c.UserName, "");
        }
    }
}