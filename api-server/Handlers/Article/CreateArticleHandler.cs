using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using api_server.Contract.Requests;
using api_server.Contract.Responses;
using api_server.Data;
using api_server.Data.Models;
using Microsoft.AspNetCore.Http;

namespace api_server.Handlers
{
    public class CreateArticleHandler : IHandler<CreateArticleRequest, IdResponse>
    {
        private readonly ApplicationDBContext _appDBContext;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CreateArticleHandler(ApplicationDBContext appDBContext, IHttpContextAccessor httpContextAccessor)
        {
            _appDBContext = appDBContext;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<IdResponse> Handle(CreateArticleRequest request)
        {
            (string title, string content, string description, List<int> tagIds) = request.NewArticle;

            Article articleToAdd = new Article
            {
                Title = title,
                Content = content,
                Description = description,
                AuthorId = int.Parse(_httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Name).Value)
            };

            await _appDBContext.Articles.AddAsync(articleToAdd);
            await _appDBContext.SaveChangesAsync();

            foreach (var tagId in tagIds)
            {
                TagAttributed newTagAttributed = new TagAttributed { TagId = tagId, ArticleId = articleToAdd.Id };
                await _appDBContext.TagsAttributed.AddAsync(newTagAttributed);
            };

            await _appDBContext.SaveChangesAsync();

            return new IdResponse { Id = articleToAdd.Id };
        }
    }
}
