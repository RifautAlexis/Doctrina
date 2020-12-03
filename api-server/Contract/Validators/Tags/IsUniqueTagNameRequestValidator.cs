using api_server.Contract.Requests;
using FluentValidation;

namespace api_server.Contract.Validators
{
    public class IsUniqueTagNameRequestValidator : AbstractValidator<IsUniqueTagNameRequest>
    {
        public IsUniqueTagNameRequestValidator()
        {
            RuleFor(request => request.IsUniqueTagNameDTO).NotNull();
            When(request => request.IsUniqueTagNameDTO != null,
                () =>
                {
                    RuleFor(request => request.IsUniqueTagNameDTO).SetValidator(new IsUniqueTagNameDTOValidator());
                });
        }
    }
}
