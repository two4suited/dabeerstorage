using DaBeerStorage.Functions.ApiModels.Beer;
using DaBeerStorage.Functions.Validators.ApiModels.Beer;
using FluentValidation.TestHelper;
using Xunit;

namespace DaBeerStorage.Tests.ApiModels.Beer
{
    public class MoveTest
    {
        private Move _move;
        private MoveValidator _validator;

        public MoveTest()
        {
            _move = new Move()
            {
                BeerId = "1",
                NewLocation = "T",
                UserName = "T"
            };
            
            _validator = new MoveValidator();
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
        [Fact]
        public void ShouldHaveValidationError_When_NewLocation_Is_Null()
        {
            _validator.ShouldHaveValidationErrorFor(c => c.NewLocation, null as string);
        }

        [Fact]
        public void ShouldHaveValidationError_When_NewLocation_Is_EmptyString()
        {
            _validator.ShouldHaveValidationErrorFor(c => c.NewLocation, "");
        }
    }
}