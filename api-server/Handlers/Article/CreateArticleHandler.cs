using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using api_server.Contract.Requests;
using api_server.Contract.Responses;
using api_server.Data;
using api_server.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using api_server.Contract.Exceptions;

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
            (string title, string content, string description, List<int> tagIds, int readingListId) = request.NewArticle;

            bool isUniqueTitle = await _appDBContext.Articles.AllAsync(a => a.Title.ToLowerInvariant() != title.ToLowerInvariant());
            if (!isUniqueTitle) throw new ArgumentException();

            foreach (var tagId in tagIds)
            {
                bool existTagId = await _appDBContext.Tags.AllAsync(a => a.Id != tagId);
                if (!existTagId) throw new ArgumentException();
            }

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

            return new IdResponse { Data = articleToAdd.Id };
        }
    }
}
