using api_server.Contract.Requests;
using FluentValidation;

namespace api_server.Contract.Validators.Authentication
{
    public class SigninRequestValidator : AbstractValidator<SigninRequest>
    {
        public SigninRequestValidator()
        {
            RuleFor(request => request.SigninDTO).NotNull();
            When(request => request.SigninDTO != null,
                () => { RuleFor(request => request.SigninDTO).SetValidator(new SigninDTOValidator()); });
        }
    }
}
