using api_server.Contract.Requests;
using FluentValidation;

namespace api_server.Contract.Validators
{
    public class EditReadingListRequestValidator : AbstractValidator<EditReadingListRequest>
    {
        public EditReadingListRequestValidator()
        {
            RuleFor(request => request.ReadingListToEdit).NotNull();
            When(request => request.ReadingListToEdit != null,
                () =>
                {
                    RuleFor(request => request.ReadingListToEdit).SetValidator(new EditReadingListDTOValidator());
                });
        }
    }
}
