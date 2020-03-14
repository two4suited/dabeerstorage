using DaBeerStorage.Functions.ApiModels.Beer;
using FluentValidation;

namespace DaBeerStorage.Functions.Validators.ApiModels.Beer
{
    public class MoveValidator : AbstractValidator<Move>
    {
        public MoveValidator()
        {
            RuleFor(r => r.BeerId).NotEmpty().NotNull();
            RuleFor(r => r.NewLocation).NotEmpty().NotNull();
            RuleFor(r => r.UserName).NotEmpty().NotNull();
        }
    }
}