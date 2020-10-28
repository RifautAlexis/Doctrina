using System.Linq;
using System.Threading.Tasks;
using api_server.Contract.DTOs;
using api_server.Data;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

namespace api_server.Contract.Validators
{
    public class CreateArticleDTOValidator : AbstractValidator<CreateArticleDTO>
    {
        private readonly ApplicationDBContext _appDBContext;

        public CreateArticleDTOValidator(ApplicationDBContext appDBContext)
        {
            _appDBContext = appDBContext;
            RuleFor(request => request.Title)
                .SetValidator(new StringValidator())
                .MustAsync(async (title, cancellation) => await IsUniqueTitle(title)).WithMessage("'{PropertyValue}' is already taken !");
            RuleFor(request => request.Description)
                .SetValidator(new StringValidator());
            RuleFor(request => request.Content)
                .SetValidator(new StringValidator());
            RuleFor(request => request.TagIds)
                .NotEmpty()
                .WithMessage("'{PropertyName}' can not be empty");
            RuleForEach(request => request.TagIds)
                .MustAsync(async (tagid, _) => await ExistTag(tagid)).WithMessage("'{PropertyValue}' doesn't exist !");
        }

        private async Task<bool> IsUniqueTitle(string value)
        {

            var titles = await _appDBContext.Articles.Select(a => a.Title).ToListAsync();
            var lol = titles.All(title => title.ToLowerInvariant() != value.ToLowerInvariant());
            System.Console.WriteLine(lol);
            return lol;
        }

        private async Task<bool> ExistTag(int tagId)
        {
            return await _appDBContext.Tags
                .AnyAsync(tag => tag.Id == tagId);
        }
    }
}
