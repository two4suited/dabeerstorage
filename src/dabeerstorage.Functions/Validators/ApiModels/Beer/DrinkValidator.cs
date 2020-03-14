using DaBeerStorage.Functions.ApiModels.Beer;
using FluentValidation;

namespace DaBeerStorage.Functions.Validators.ApiModels.Beer
{
    public class DrinkValidator : AbstractValidator<Drink>
    {
        public DrinkValidator()
        {
            RuleFor(r => r.BeerId).NotEmpty().NotNull();
            RuleFor(r => r.UserName).NotEmpty().NotNull();
        }
    }
}