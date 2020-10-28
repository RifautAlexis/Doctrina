using System.Linq;
using System.Threading.Tasks;
using api_server.Contract.Requests;
using api_server.Contract.Responses;
using api_server.Contract.Mappers;
using api_server.Data;
using Microsoft.EntityFrameworkCore;
using api_server.Contract.Exceptions;
using api_server.Data.Models;

namespace api_server.Handlers
{
    public class GetArticleByIdHandler : IHandler<GetArticleByIdRequest, ArticleResponse>
    {
        private readonly ApplicationDBContext _appDBContext;

        public GetArticleByIdHandler(ApplicationDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }

        public async Task<ArticleResponse> Handle(GetArticleByIdRequest request)
        {

            int articleId = request.Id;

            Article article = await _appDBContext.Articles
                .Where(a => a.Id == articleId)
                .Include(a => a.Tags)
                    .ThenInclude(ta => ta.Tag)
                .Include(a => a.Author)
                .FirstOrDefaultAsync();

            if (article == null) throw new NotFoundException();

            return new ArticleResponse { Article = article.ToDTO() };
        }
    }
}
