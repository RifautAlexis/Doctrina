using api_server.Contract.DTOs;
using FluentValidation;

namespace api_server.Contract.Validators
{
    public class CreateReadingListDTOValidator : AbstractValidator<CreateReadingListDTO>
    {

        public CreateReadingListDTOValidator()
        {
            RuleFor(request => request.Name)
                .SetValidator(new StringValidator());
            RuleFor(request => request.Description)
                .SetValidator(new StringValidator());
        }
    }
}
