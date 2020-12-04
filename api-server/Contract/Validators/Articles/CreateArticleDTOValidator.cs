using api_server.Contract.DTOs;
using FluentValidation;

namespace api_server.Contract.Validators
{
    public class CreateArticleDTOValidator : AbstractValidator<CreateArticleDTO>
    {

        public CreateArticleDTOValidator()
        {
            RuleFor(request => request.Title)
                .SetValidator(new StringValidator());
            RuleFor(request => request.Description)
                .SetValidator(new StringValidator());
            RuleFor(request => request.Content)
                .SetValidator(new StringValidator());
            RuleFor(request => request.TagIds)
                .NotEmpty()
                .WithMessage("'{PropertyName}' can not be empty");
        }
    }
}
