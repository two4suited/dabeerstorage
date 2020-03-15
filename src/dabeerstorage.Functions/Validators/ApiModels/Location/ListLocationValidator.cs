using System.Collections.Generic;
using DaBeerStorage.Functions.ApiModels.Location;
using FluentValidation;

namespace DaBeerStorage.Functions.Validators.ApiModels.Location
{
    public class ListLocationValidator : AbstractValidator<ListLocation>
    {
        public ListLocationValidator()
        {
            RuleFor(create => create.UserName).NotEmpty().NotNull();
        }
    }
}