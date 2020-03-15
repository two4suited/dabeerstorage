using DaBeerStorage.Functions.ApiModels.Search;
using FluentValidation;

namespace DaBeerStorage.Functions.Validators.ApiModels.Search
{
    public class ByNameValidator : AbstractValidator<ByName>
    {
        public ByNameValidator()
        {
            RuleFor(x => x.SearchValue).NotEmpty().NotNull();
        }
    }
}