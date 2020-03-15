using DaBeerStorage.Functions.ApiModels.Location;
using FluentValidation;

namespace DaBeerStorage.Functions.Validators.ApiModels.Location
{
    public class AddValidator : AbstractValidator<Add>
    {
        public AddValidator()
        {
            RuleFor(create => create.Name).NotEmpty().NotNull();
            RuleFor(create => create.UserName).NotEmpty().NotNull();
        }
    }
}