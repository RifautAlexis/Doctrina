using api_server.Contract.Requests;
using api_server.Data;
using FluentValidation;

namespace api_server.Contract.Validators.Articles
{
    //public class IsUniqueTitleRequestValidator : AbstractValidator<IsUniqueTitleRequest>
    //{
    //    public IsUniqueTitleRequestValidator(ApplicationDBContext appDBContext)
    //    {
    //        RuleFor(request => request.isUniqueTitleDTO).NotNull();
    //        When(request => request.isUniqueTitleDTO != null,
    //            () => { RuleFor(request => request.isUniqueTitleDTO).SetValidator(new IsUniqueTitleDTOValidator(appDBContext)); });
    //    }
    //}
}
