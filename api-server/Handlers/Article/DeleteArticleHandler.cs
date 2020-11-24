using System.Threading.Tasks;
using api_server.Contract.Responses;
using api_server.Contract.Requests;
using api_server.Data;
using api_server.Data.Models;
using api_server.Contract.Exceptions;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace api_server.Handlers
{
    public class DeleteArticleHandler : IHandler<DeleteArticleRequest, BooleanResponse>
    {
        private readonly ApplicationDBContext _appDBContext;

        public DeleteArticleHandler(ApplicationDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }

        public async Task<BooleanResponse> Handle(DeleteArticleRequest request)
        {
            Article article = await _appDBContext.Articles
                .FindAsync(request.Id);

            if (article == null) throw new NotFoundException();

            List<TagAttributed> tagsAttributed = await _appDBContext.TagsAttributed
                .Where(ta => ta.ArticleId == article.Id)
                .ToListAsync();

            _appDBContext.TagsAttributed.RemoveRange(tagsAttributed);
            await _appDBContext.SaveChangesAsync();

            _appDBContext.Articles.Remove(article);
            await _appDBContext.SaveChangesAsync();

            return new BooleanResponse { Data = true };
        }
    }
}
