using System.Linq;
using System.Threading.Tasks;
using api_server.Contract.Requests;
using api_server.Data;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

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
    public class IsUniqueTitleRequestValidator : AbstractValidator<IsUniqueTitleRequest>
    {

        public IsUniqueTitleRequestValidator()
        {
            RuleFor(isUniqueTitleRequest => isUniqueTitleRequest.Title)
                .SetValidator(new StringValidator());
        }
    }
}
