using FluentValidation;

namespace api_server.Contract.Validators
{
    public class StringValidator : AbstractValidator<string>
    {
        public StringValidator()
        {
            RuleFor(str => str)
                .NotEmpty()
                .WithMessage("'{PropertyName}' can not be empty");
        }
    }
}
