using DaBeerStorage.Functions.Validators.ApiModels.Search;
using FluentValidation.TestHelper;
using Xunit;

namespace DaBeerStorage.Tests.ApiModels.Search
{
    public class ByNameTest
    {
        private readonly ByNameValidator _validator;
        public ByNameTest()
        {
            _validator = new ByNameValidator();
        }
        
        [Fact]
        public void ShouldHaveValidationError_When_UserName_IsNull()
        {
            _validator.ShouldHaveValidationErrorFor(c => c.SearchValue, null as string);
        }

        [Fact]
        public void ShouldHaveValidationError_When_UserName_Is_EmptyString()
        {
            _validator.ShouldHaveValidationErrorFor(c => c.SearchValue, "");
        }
    }
}