

using api_server.Contract.DTOs;
using FluentValidation;

namespace api_server.Contract.Validators.Authentication
{
    public class SigninDTOValidator : AbstractValidator<SigninDTO>
    {
        public SigninDTOValidator()
        {
            RuleFor(s => s.Email)
                .NotEmpty().WithMessage("Can't be empty !")
                .EmailAddress().WithMessage("Wrong email format !");
            RuleFor(s => s.Password)
                .NotEmpty().WithMessage("Can't be empty !")
                .MinimumLength(3).WithMessage("Require at least 3 characters !");
        }
    }
}
