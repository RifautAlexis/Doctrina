using api_server.Contract.DTOs;
using FluentValidation;

namespace api_server.Contract.Validators
{
    public class IsUniqueReadingListNameDTOValidator : AbstractValidator<IsUniqueReadingListNameDTO>
    {

        public IsUniqueReadingListNameDTOValidator()
        {
            RuleFor(isUniqueTitleRequest => isUniqueTitleRequest.Name)
                .SetValidator(new StringValidator());
        }
    }
}
