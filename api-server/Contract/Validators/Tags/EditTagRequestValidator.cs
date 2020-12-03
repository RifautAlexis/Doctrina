using api_server.Contract.Requests;
using FluentValidation;

namespace api_server.Contract.Validators
{
    public class EditTagRequestValidator : AbstractValidator<EditTagRequest>
    {
        public EditTagRequestValidator()
        {
            RuleFor(request => request.TagToEdit).NotNull();
            When(request => request.TagToEdit != null,
                () =>
                {
                    RuleFor(request => request.TagToEdit).SetValidator(new EditTagDTOValidator());
                });
        }
    }
}
