using api_server.Contract.Requests;
using FluentValidation;

namespace api_server.Contract.Validators
{
    public class CreateTagRequestValidator : AbstractValidator<CreateTagRequest>
    {
        public CreateTagRequestValidator()
        {
            RuleFor(request => request.NewTag).NotNull();
            When(request => request.NewTag != null,
                () =>
                {
                    RuleFor(request => request.NewTag).SetValidator(new CreateTagDTOValidator());
                });
        }
    }
}
