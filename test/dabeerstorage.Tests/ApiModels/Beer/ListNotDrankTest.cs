using DaBeerStorage.Functions.ApiModels.Beer;
using DaBeerStorage.Functions.Validators.ApiModels.Beer;
using FluentValidation.TestHelper;
using Xunit;

namespace DaBeerStorage.Tests.ApiModels.Beer
{
    public class ListNotDrankTest
    {
        private ListNotDrank _listNotDrank;
        private ListNotDrankValidator _validator;

        public ListNotDrankTest()
        {
            _listNotDrank = new ListNotDrank()
            {
                Location = "1",
                UserName = "T"
            };
            _validator = new ListNotDrankValidator();
        }
        [Fact]
        public void ShouldHaveValidationError_When_Location_Is_Null()
        {
            _validator.ShouldHaveValidationErrorFor(c => c.Location, null as string);
        }

        [Fact]
        public void ShouldHaveValidationError_When_Location_Is_EmptyString()
        {
            _validator.ShouldHaveValidationErrorFor(c => c.Location, "");
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