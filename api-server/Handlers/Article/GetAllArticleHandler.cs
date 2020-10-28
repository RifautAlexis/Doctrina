using System.Collections.Generic;
using System.Threading.Tasks;
using api_server.Contract.Mappers;
using api_server.Contract.Requests;
using api_server.Contract.Responses;
using api_server.Data;
using api_server.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace api_server.Handlers
{
    public class GetAllArticleHandler : IHandler<GetAllArticleRequest, ArticlesResponse>
    {
        private readonly ApplicationDBContext _appDBContext;

        public GetAllArticleHandler(ApplicationDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }

        public async Task<ArticlesResponse> Handle(GetAllArticleRequest request)
        {
            List<Article> articles = await _appDBContext.Articles
                .Include(a => a.Tags)
                    .ThenInclude(ta => ta.Tag)
                .Include(a => a.Author)
                .ToListAsync();

            return new ArticlesResponse { Articles = articles.ToDTOs() };
        }
    }
}
