using api_server.Contract.DTOs;
using FluentValidation;

namespace api_server.Contract.Validators
{
    public class IsUniqueTagNameDTOValidator : AbstractValidator<IsUniqueTagNameDTO>
    {

        public IsUniqueTagNameDTOValidator()
        {
            RuleFor(isUniqueTitleRequest => isUniqueTitleRequest.Name)
                .SetValidator(new StringValidator());
        }
    }
}
