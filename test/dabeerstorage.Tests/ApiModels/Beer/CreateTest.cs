using System;
using AutoFixture.Xunit2;
using DaBeerStorage.Functions.ApiModels.Beer;
using Shouldly;
using Xunit;

namespace DaBeerStorage.Tests.ApiModels.Beer
{
    public class CreateTest 
    {
        private Create create;
        public CreateTest()
        {
            create = new Create()
            {
                BeerName = "Test",
                UserName = "Test",
                Description = "Test",
                Ibu = "145"
            };
        }
        [Fact]
        public void Valid_ShouldBe_False_When_UserName_Is_Null()
        {
            create.UserName = null;
            create.Validate();
            create.Valid.ShouldBeFalse();
        }

        [Fact]
        public void Valid_ShouldBe_False_When_UserName_Is_EmptyString()
        {
            create.UserName = "";
            create.Validate();
            create.Valid.ShouldBeFalse();
        }

        [Fact]
        public void Valid_ShouldBe_True_When_Description_Has_Value()
        {
            create.Validate();
            create.Valid.ShouldBeTrue();
        }
        
        [Fact]
        public void Valid_ShouldBe_False_When_Description_Is_Null()
        {
            create.Description = null;
            create.Validate();
            create.Valid.ShouldBeFalse();
        }

        [Fact]
        public void Valid_ShouldBe_False_When_Description_Is_EmptyString()
        {
            create.Description = "";
            create.Validate();
            create.Valid.ShouldBeFalse();
        }

        [Fact]
        public void Valid_ShouldBe_True_When_UserName_Has_Value()
        {
            create.Validate();
            create.Valid.ShouldBeTrue();
        }

        [Fact]
        public void Valid_ShouldBe_False_When_BeerName_IsNull()
        {
            create.BeerName = null;
            create.Validate();
            create.Valid.ShouldBeFalse();
        }

        [Fact]
        public void Valid_ShouldBe_False_When_BeerName_Is_EmptyString()
        {
            create.BeerName = "";
            create.Validate();
            create.Valid.ShouldBeFalse();
        }
        [Fact]
        public void Valid_ShouldBe_True_When_BeerName_Has_Value()
        {
            create.Validate();
            create.Valid.ShouldBeTrue();
        }
        
        [Fact]
        public void Valid_ShouldBe_False_When_Ibu_IsNull()
        {
            create.Ibu = null;
            create.Validate();
            create.Valid.ShouldBeFalse();
        }

        [Fact]
        public void Valid_ShouldBe_False_When_Ibu_Is_EmptyString()
        {
            create.Ibu = "";
            create.Validate();
            create.Valid.ShouldBeFalse();
        }
        [Fact]
        public void Valid_ShouldBe_True_When_Ibu_Has_Value()
        {
            create.Validate();
            create.Valid.ShouldBeTrue();
        }

        [Fact]
        public void Valid_ShouldBe_False_When_Quantity_Is_Zero()
        {
            create.Quantity = 0;
            create.Validate();
            create.Valid.ShouldBeFalse();
        }
        
        [Fact]
        public void Valid_ShouldBe_False_When_Quantity_Is_Negative()
        {
            create.Quantity = -1;
            create.Validate();
            create.Valid.ShouldBeFalse();
        }
        [Fact]
        public void Valid_ShouldBe_True_When_Quantity_Is_Positve()
        {
            create.Quantity = 1;
            create.Validate();
            create.Valid.ShouldBeTrue();
        }

        [Fact]
        public void Valid_ShouldBe_False_When_CreateDate_Is_Min()
        {
            create.CreateDate=DateTimeOffset.MinValue;
            create.Validate();
            create.Valid.ShouldBeFalse();
        }
    }
}