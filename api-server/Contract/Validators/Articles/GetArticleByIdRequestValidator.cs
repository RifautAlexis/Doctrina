using api_server.Contract.Requests;
using Cityton.Api.Contracts.Validators;
using FluentValidation;

namespace api_server.Contract.Validators
{
    public class GetArticleByIdRequestValidator : AbstractValidator<GetArticleByIdRequest>
    {
        public GetArticleByIdRequestValidator()
        {
            RuleFor(request => request.Id)
                .SetValidator(new IdValidator());
        }
    }
}
