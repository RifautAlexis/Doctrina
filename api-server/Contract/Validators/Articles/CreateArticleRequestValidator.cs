using api_server.Contract.Requests;
using FluentValidation;

namespace api_server.Contract.Validators
{
    public class CreateArticleRequestValidator : AbstractValidator<CreateArticleRequest>
    {
        public CreateArticleRequestValidator()
        {
            RuleFor(request => request.NewArticle).NotNull();
            When(request => request.NewArticle != null,
                () =>
                {
                    RuleFor(request => request.NewArticle).SetValidator(new CreateArticleDTOValidator());
                });
        }
    }
}
