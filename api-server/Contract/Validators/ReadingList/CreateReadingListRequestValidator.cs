using api_server.Contract.Requests;
using FluentValidation;

namespace api_server.Contract.Validators
{
    public class CreateReadingListRequestValidator : AbstractValidator<CreateReadingListRequest>
    {
        public CreateReadingListRequestValidator()
        {
            RuleFor(request => request.NewReadingList).NotNull();
            When(request => request.NewReadingList != null,
                () =>
                {
                    RuleFor(request => request.NewReadingList).SetValidator(new CreateReadingListDTOValidator());
                });
        }
    }
}
