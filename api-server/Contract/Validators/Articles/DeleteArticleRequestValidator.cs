using api_server.Contract.Requests;
using Cityton.Api.Contracts.Validators;
using FluentValidation;

namespace api_server.Contract.Validators.Articles
{
    public class DeleteArticleRequestValidator : AbstractValidator<DeleteArticleRequest>
    {
        public DeleteArticleRequestValidator()
        {
            RuleFor(request => request.Id)
                .SetValidator(new IdValidator());
        }
    }
}
