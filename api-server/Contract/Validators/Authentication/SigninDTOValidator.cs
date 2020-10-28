

using api_server.Contract.DTOs;
using FluentValidation;

namespace api_server.Contract.Validators.Authentication
{
    public class SigninDTOValidator : AbstractValidator<SigninDTO>
    {
        public SigninDTOValidator()
        {
            RuleFor(s => s.Email)
                .Cascade(CascadeMode.Stop)
                .SetValidator(new StringValidator())
                .EmailAddress().WithMessage("Wrong email format !");
            RuleFor(s => s.Password)
                .Cascade(CascadeMode.Stop)
                .SetValidator(new StringValidator())
                .MinimumLength(3).WithMessage("Require at least 3 characters !");
        }
    }
}
