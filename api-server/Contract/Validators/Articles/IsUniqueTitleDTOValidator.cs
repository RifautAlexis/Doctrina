using System.Linq;
using System.Threading.Tasks;
using api_server.Contract.DTOs;
using api_server.Data;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

namespace api_server.Contract.Validators.Articles
{
    public class IsUniqueTitleDTOValidator : AbstractValidator<IsUniqueTitleDTO>
    {
        private readonly ApplicationDBContext _appDBContext;

        public IsUniqueTitleDTOValidator(ApplicationDBContext appDBContext)
        {
            _appDBContext = appDBContext;

            RuleFor(isUniqueTitleDTO => isUniqueTitleDTO.Title)
                .SetValidator(new StringValidator())
                .MustAsync(async (title, cancellation) => !(await IsUniqueTitle(title)))
                .WithMessage("{PropertyValue} is already taken !");
        }

        private async Task<bool> IsUniqueTitle(string title)
        {
            return await _appDBContext.Articles.Where(c => c.Title == title).FirstOrDefaultAsync() != null;
        }
    }
}
