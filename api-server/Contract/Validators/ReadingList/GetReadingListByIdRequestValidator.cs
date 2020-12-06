using api_server.Contract.Requests;
using Cityton.Api.Contracts.Validators;
using FluentValidation;

namespace api_server.Contract.Validators.ReadingList
{
    public class GetReadingListByIdRequestValidator : AbstractValidator<GetReadingListByIdRequest>
    {
        public GetReadingListByIdRequestValidator()
        {
            RuleFor(request => request.Id)
                .SetValidator(new IdValidator());
        }
    }
}
