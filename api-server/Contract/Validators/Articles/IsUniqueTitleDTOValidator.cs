using api_server.Contract.DTOs;
using FluentValidation;

namespace api_server.Contract.Validators
{
    public class IsUniqueTitleDTOValidator : AbstractValidator<IsUniqueTitleDTO>
    {

        public IsUniqueTitleDTOValidator()
        {
            RuleFor(isUniqueTitleRequest => isUniqueTitleRequest.Title)
                .SetValidator(new StringValidator());
        }
    }
}
