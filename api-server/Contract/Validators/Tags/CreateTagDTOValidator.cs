using api_server.Contract.DTOs;
using FluentValidation;

namespace api_server.Contract.Validators
{
    public class CreateTagDTOValidator : AbstractValidator<CreateTagDTO>
    {

        public CreateTagDTOValidator()
        {
            RuleFor(request => request.Name)
                .SetValidator(new StringValidator());
        }
    }
}
