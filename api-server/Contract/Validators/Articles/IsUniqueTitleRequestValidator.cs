using api_server.Contract.Requests;
using api_server.Data;
using FluentValidation;

namespace api_server.Contract.Validators
{
    public class IsUniqueTitleRequestValidator : AbstractValidator<IsUniqueTitleRequest>
    {
        public IsUniqueTitleRequestValidator(ApplicationDBContext appDBContext)
        {
            RuleFor(request => request.IsUniqueTitleDTO).NotNull();
            When(request => request.IsUniqueTitleDTO != null,
                () =>
                {
                    RuleFor(request => request.IsUniqueTitleDTO).SetValidator(new IsUniqueTitleDTOValidator());
                });
        }
    }
}
