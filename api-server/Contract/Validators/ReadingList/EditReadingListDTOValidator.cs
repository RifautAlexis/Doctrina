using System.Linq;
using api_server.Contract.DTOs;
using Cityton.Api.Contracts.Validators;
using FluentValidation;

namespace api_server.Contract.Validators
{
    public class EditReadingListDTOValidator : AbstractValidator<EditReadingListDTO>
    {

        public EditReadingListDTOValidator()
        {

            RuleFor(request => request.Id)
                .SetValidator(new IdValidator());
            RuleFor(request => request.Name)
                .SetValidator(new StringValidator());
            RuleFor(request => request.Description)
                .SetValidator(new StringValidator());
            RuleFor(request => request.ArticleIds)
                .Must(articleIds => articleIds.Count != articleIds.Distinct().Count());
        }
    }
}