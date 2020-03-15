using DaBeerStorage.Functions.Validators.ApiModels.Location;
using FluentValidation.TestHelper;
using Xunit;

namespace DaBeerStorage.Tests.ApiModels.Location
{
    public class ListLocationTest
    {
        private readonly ListLocationValidator _validator;
        public ListLocationTest()
        {
            _validator = new ListLocationValidator();
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