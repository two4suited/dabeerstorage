using System;
using DaBeerStorage.Functions.ApiModels.Beer;
using FluentValidation;

namespace DaBeerStorage.Functions.Validators.ApiModels.Beer
{
    public class CreateValidator : AbstractValidator<Create>
    {
        public CreateValidator()
        {
            RuleFor(create => create.Description).NotEmpty().NotNull();
            RuleFor(create => create.UserName).NotEmpty().NotNull();
            RuleFor(create => create.Ibu).NotEmpty().NotNull();
            RuleFor(create => create.Location).NotEmpty().NotNull();
            RuleFor(create => create.BreweryName).NotEmpty().NotNull();
            RuleFor(create => create.Style).NotEmpty().NotNull();
            RuleFor(create => create.CreateDate).NotEqual(DateTimeOffset.MinValue);
            RuleFor(create => create.LabelPath).NotEmpty().NotNull();
            RuleFor(create => create.BeerName).NotEmpty().NotNull();
            RuleFor(create => create.BreweryState).NotEmpty().NotNull();
            RuleFor(create => create.UntappedId).NotEmpty().NotNull();
            RuleFor(create => create.BeerId).NotEmpty().NotNull();
            RuleFor(create => create.AlcoholByVolume).NotEmpty().NotNull();
            RuleFor(create => create.Quantity).GreaterThan(0);
        }
    }
}