using api_server.Contract.Requests;
using FluentValidation;

namespace api_server.Contract.Validators
{
    public class IsUniqueReadingListNameRequestValidator : AbstractValidator<IsUniqueReadingListNameRequest>
    {
        public IsUniqueReadingListNameRequestValidator()
        {
            RuleFor(request => request.IsUniqueReadingListNameDTO).NotNull();
            When(request => request.IsUniqueReadingListNameDTO != null,
                () =>
                {
                    RuleFor(request => request.IsUniqueReadingListNameDTO).SetValidator(new IsUniqueReadingListNameDTOValidator());
                });
        }
    }
}
