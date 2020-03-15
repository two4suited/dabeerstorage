using DaBeerStorage.Functions.Validators.ApiModels.Location;
using DaBeerStorage.Functions.Validators.ApiModels.Search;
using FluentValidation.TestHelper;
using Xunit;

namespace DaBeerStorage.Tests.ApiModels.Search
{
    public class ByIdTest
    {
        private readonly ByIdValidator _validator;
        public ByIdTest()
        {
            _validator = new ByIdValidator();
        }
        
        [Fact]
        public void ShouldHaveValidationError_When_Id_IsNull()
        {
            _validator.ShouldHaveValidationErrorFor(c => c.Id, null as string);
        }

        [Fact]
        public void ShouldHaveValidationError_When_Id_Is_EmptyString()
        {
            _validator.ShouldHaveValidationErrorFor(c => c.Id, "");
        }
    }
}