using DaBeerStorage.Functions.ApiModels.Search;
using FluentValidation;

namespace DaBeerStorage.Functions.Validators.ApiModels.Search
{
    public class ByIdValidator : AbstractValidator<ById>
    {
        public ByIdValidator()
        {
            RuleFor(x => x.Id).NotEmpty().NotNull();
        }
    }
}