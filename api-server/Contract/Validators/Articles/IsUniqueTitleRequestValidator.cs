using api_server.Contract.Requests;
using FluentValidation;

namespace api_server.Contract.Validators.Articles
{
    public class IsUniqueTitleRequestValidator : AbstractValidator<IsUniqueTitleRequest>
    {
        public IsUniqueTitleRequestValidator()
        {
            RuleFor(request => request.Title)
                .SetValidator(new StringValidator());
        }
    }
}
