using api_server.Contract.Requests;
using api_server.Data;
using FluentValidation;

namespace api_server.Contract.Validators.Articles
{
    public class CreateArticleRequestValidator : AbstractValidator<CreateArticleRequest>
    {
        public CreateArticleRequestValidator(ApplicationDBContext appDBContext)
        {
            RuleFor(request => request.NewArticle).NotNull();
            When(request => request.NewArticle != null,
                () => { RuleFor(request => request.NewArticle).SetValidator(new CreateArticleDTOValidator(appDBContext)); });
        }
    }
}
