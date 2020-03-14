using DaBeerStorage.Functions.ApiModels.Beer;
using DaBeerStorage.Functions.Validators.ApiModels.Beer;
using FluentValidation.TestHelper;
using Xunit;

namespace DaBeerStorage.Tests.ApiModels.Beer
{
    public class DrinkTest
    {
        private Drink _drink;
        private DrinkValidator _validator;
        public DrinkTest()
        {
            _drink = new Drink()
            {
                BeerId = "1",
                UserName = "T"
            };
            _validator = new DrinkValidator();
        }
        
        [Fact]
        public void ShouldHaveValidationError_When_BeerId_Is_Null()
        {
            _validator.ShouldHaveValidationErrorFor(c => c.BeerId, null as string);
        }

        [Fact]
        public void ShouldHaveValidationError_When_BeerId_Is_EmptyString()
        {
            _validator.ShouldHaveValidationErrorFor(c => c.BeerId, "");
        }
        [Fact]
        public void ShouldHaveValidationError_When_UserName_Is_Null()
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