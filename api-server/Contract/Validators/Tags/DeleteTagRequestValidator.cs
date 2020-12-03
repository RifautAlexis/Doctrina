using api_server.Contract.Requests;
using Cityton.Api.Contracts.Validators;
using FluentValidation;

namespace api_server.Contract.Validators.Articles
{
    public class DeleteTagRequestValidator : AbstractValidator<DeleteTagRequest>
    {
        public DeleteTagRequestValidator()
        {
            RuleFor(request => request.Id)
                .SetValidator(new IdValidator());
        }
    }
}
