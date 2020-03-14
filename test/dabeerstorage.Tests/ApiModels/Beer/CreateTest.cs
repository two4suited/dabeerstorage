using System;
using AutoFixture.Xunit2;
using DaBeerStorage.Functions.ApiModels.Beer;
using DaBeerStorage.Functions.Validators.ApiModels.Beer;
using FluentValidation.TestHelper;
using Shouldly;
using Xunit;

namespace DaBeerStorage.Tests.ApiModels.Beer
{
    public class CreateTest 
    {
        private Create _create;
        private readonly CreateValidator _validator;
        public CreateTest()
        {
            _create = new Create()
            {
                BeerName = "Test",
                UserName = "Test",
                Description = "Test",
                Ibu = "145",
                Location = "Test",
                Style = "T",
                BeerId = "1",
                BreweryName = "T",
                BreweryState = "OR",
                LabelPath = "Test",
                UntappedId = "1",
                AlcoholByVolume = "5"
            };
            _validator = new CreateValidator();
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
        public void ShouldHaveValidationError_When_Description_Is_Null()
        {
            _validator.ShouldHaveValidationErrorFor(c => c.Description, "");
        }

        [Fact]
        public void ShouldHaveValidationError_When_Description_Is_EmptyString()
        {
            _validator.ShouldHaveValidationErrorFor(c => c.Description, null as string);
        }

        [Fact]
        public void ShouldHaveValidationError_When_BeerName_IsNull()
        {
            _validator.ShouldHaveValidationErrorFor(c => c.BeerName, null as string);
        }

        [Fact]
        public void ShouldHaveValidationError_When_BeerName_Is_EmptyString()
        {
            _validator.ShouldHaveValidationErrorFor(c => c.BeerName, "");
        }

        [Fact]
        public void ShouldHaveValidationError_When_Ibu_IsNull()
        {
            _validator.ShouldHaveValidationErrorFor(c => c.Ibu, null as string);
        }

        [Fact]
        public void ShouldHaveValidationError_When_Ibu_Is_EmptyString()
        {
            _validator.ShouldHaveValidationErrorFor(c => c.Ibu, "");
        }
      
        [Fact]
        public void ShouldHaveValidationError_When_Quantity_Is_Zero()
        {
            _validator.ShouldHaveValidationErrorFor(c => c.Quantity, 0);
        }
        
        [Fact]
        public void ShouldHaveValidationError_When_Quantity_Is_Negative()
        {
            _validator.ShouldHaveValidationErrorFor(c => c.Quantity, -1);
        }
        [Theory,AutoData]
        public void IsValid_ShouldBe_True_When_Quantity_Is_Positive(Create c)
        {
            c.Quantity = 1;
            _validator.Validate(c).IsValid.ShouldBeTrue();
        }

        [Fact]
        public void ShouldHaveValidationError_When_CreateDate_Is_Min()
        {
            _validator.ShouldHaveValidationErrorFor(c => c.CreateDate, DateTimeOffset.MinValue);
        }
        [Fact]
        public void ShouldHaveValidationError_When_BeerId_IsNull()
        {
            _validator.ShouldHaveValidationErrorFor(c => c.BeerId, null as string);
        }

        [Fact]
        public void ShouldHaveValidationError_When_BeerId_Is_EmptyString()
        {
            _validator.ShouldHaveValidationErrorFor(c => c.BeerId, "");
        }
       
        [Fact]
        public void ShouldHaveValidationError_When_UntappdId_IsNull()
        {
            _validator.ShouldHaveValidationErrorFor(c => c.UntappedId, null as string);
        }

        [Fact]
        public void ShouldHaveValidationError_When_UntappdId_Is_EmptyString()
        {
            _validator.ShouldHaveValidationErrorFor(c => c.UntappedId, "");
        }
        [Fact]
        public void ShouldHaveValidationError_When_AlcoholByVolume_IsNull()
        {
            _validator.ShouldHaveValidationErrorFor(c => c.AlcoholByVolume, null as string);
        }

        [Fact]
        public void ShouldHaveValidationError_When_AlcoholByVolume_Is_EmptyString()
        {
            _validator.ShouldHaveValidationErrorFor(c => c.AlcoholByVolume, "");
        }
        [Fact]
        public void ShouldHaveValidationError_When_Location_IsNull()
        {
            _validator.ShouldHaveValidationErrorFor(c => c.Location, null as string);
        }

        [Fact]
        public void ShouldHaveValidationError_When_Location_Is_EmptyString()
        {
            _validator.ShouldHaveValidationErrorFor(c => c.Location, "");
        }
       
        [Fact]
        public void ShouldHaveValidationError_When_BreweryName_IsNull()
        {
            _validator.ShouldHaveValidationErrorFor(c => c.BreweryName, null as string);
        }

        [Fact]
        public void ShouldHaveValidationError_When_BreweryName_Is_EmptyString()
        {
            _validator.ShouldHaveValidationErrorFor(c => c.BreweryName, "");
        }
        [Fact]
        public void ShouldHaveValidationError_When_BreweryState_IsNull()
        {
            _validator.ShouldHaveValidationErrorFor(c => c.BreweryState, null as string);
        }

        [Fact]
        public void ShouldHaveValidationError_When_BreweryState_Is_EmptyString()
        {
            _validator.ShouldHaveValidationErrorFor(c => c.BreweryState, "");
        }
        [Fact]
        public void ShouldHaveValidationError_False_When_LabelPath_IsNull()
        {
            _validator.ShouldHaveValidationErrorFor(c => c.LabelPath, null as string);
        }

        [Fact]
        public void ShouldHaveValidationError_When_LabelPath_Is_EmptyString()
        {
            _validator.ShouldHaveValidationErrorFor(c => c.LabelPath, "");
        }
        [Fact]
        public void ShouldHaveValidationError_When_Style_IsNull()
        {
            _validator.ShouldHaveValidationErrorFor(c => c.Style, null as string);
        }

        [Fact]
        public void ShouldHaveValidationError_When_Style_Is_EmptyString()
        {
            _validator.ShouldHaveValidationErrorFor(c => c.Style, "");
        }
      
    }
}