using api_server.Contract.Requests;
using Cityton.Api.Contracts.Validators;
using FluentValidation;

namespace api_server.Contract.Validators
{
    public class DeleteReadingListRequestValidator : AbstractValidator<DeleteReadingListRequest>
    {
        public DeleteReadingListRequestValidator()
        {
            RuleFor(request => request.Id)
                .SetValidator(new IdValidator());
        }
    }
}
