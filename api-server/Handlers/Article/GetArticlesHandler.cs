using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api_server.Contract.Requests;
using api_server.Contract.Responses;
using api_server.Data;
using api_server.Data.Models;
using api_server.Contract.Mappers;
using Microsoft.EntityFrameworkCore;


namespace api_server.Handlers
{
    public class GetArticlesHandler : IHandler<SearchArticlesRequest, ArticlesResponse>
    {
        private readonly ApplicationDBContext _appDBContext;

        public GetArticlesHandler(ApplicationDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }

        public async Task<ArticlesResponse> Handle(SearchArticlesRequest request)
        {

            string toSearch = request.ToSearch;
            StringComparison comparison = StringComparison.OrdinalIgnoreCase;

            List<Article> articles = await _appDBContext.Articles
                .Where(a => String.IsNullOrEmpty(toSearch) ||
                    (
                        a.Title.Contains(toSearch, comparison) ||
                        a.Content.Contains(toSearch, comparison) ||
                        a.Description.Contains(toSearch, comparison) ||
                        a.Author.Username.Contains(toSearch, comparison) ||
                        a.Tags.Any(ta => ta.Tag.Name.Contains(toSearch, comparison)
                    )))
                .Include(a => a.Tags)
                .ThenInclude(ta => ta.Tag)
                .ToListAsync();

            return new ArticlesResponse { Data = articles.ToDTOs() };
        }
    }
}
