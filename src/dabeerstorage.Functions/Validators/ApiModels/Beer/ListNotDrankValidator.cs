using DaBeerStorage.Functions.ApiModels.Beer;
using FluentValidation;

namespace DaBeerStorage.Functions.Validators.ApiModels.Beer
{
    public class ListNotDrankValidator : AbstractValidator<ListNotDrank>
    {
        public ListNotDrankValidator()
        {
            RuleFor(r => r.Location).NotEmpty().NotNull();
            RuleFor(r => r.UserName).NotEmpty().NotNull();
        }
    }
}