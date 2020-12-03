using api_server.Contract.Requests;
using FluentValidation;

namespace api_server.Contract.Validators
{
    public class EditArticleRequestValidator : AbstractValidator<EditArticleRequest>
    {
        public EditArticleRequestValidator()
        {
            RuleFor(request => request.ArticleToEdit).NotNull();
            When(request => request.ArticleToEdit != null,
                () =>
                {
                    RuleFor(request => request.ArticleToEdit).SetValidator(new EditArticleDTOValidator());
                });
        }
    }
}
