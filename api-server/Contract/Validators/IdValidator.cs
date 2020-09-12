using FluentValidation;

namespace Cityton.Api.Contracts.Validators
{
    public class IdValidator : AbstractValidator<int>
    {
        public IdValidator()
        {
            RuleFor(id => id)
                .NotEmpty()
                .WithMessage("'{PropertyName}' can not be equals to 0");
        }
    }
}