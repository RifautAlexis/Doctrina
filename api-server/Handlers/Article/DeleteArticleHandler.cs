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

            List<ArticleInReadingList> articleInReadingLists = await _appDBContext.ArticlesInReadingLists
                .Where(airl => airl.ArticleId == article.Id)
                .ToListAsync();

            foreach (var articleInReadingList in articleInReadingLists)
            {
                List<ArticleInReadingList> articlesInReadingListToEdit = new List<ArticleInReadingList>();

                if (articleInReadingList.PreviousArticleId == null && articleInReadingList.NextArticleId == null) // The only one
                {
                    _appDBContext.ArticlesInReadingLists.Remove(articleInReadingList);
                }
                else if (articleInReadingList.PreviousArticleId == null && articleInReadingList.NextArticleId != null) // First one
                {
                    articlesInReadingListToEdit = await _appDBContext.ArticlesInReadingLists
                    .Where(airl => airl.ReadingListId == articleInReadingList.ReadingListId)
                    .ToListAsync();

                    ArticleInReadingList nextArticle = articlesInReadingListToEdit.FirstOrDefault(airl => airl.ArticleId == articleInReadingList.NextArticleId);
                    if (nextArticle == null) throw new ArgumentException();

                    nextArticle.PreviousArticleId = null;
                    _appDBContext.ArticlesInReadingLists.Remove(articleInReadingList);
                }
                else if (articleInReadingList.PreviousArticleId != null && articleInReadingList.NextArticleId == null) // Last one
                {
                    articlesInReadingListToEdit = await _appDBContext.ArticlesInReadingLists
                    .Where(airl => airl.ReadingListId == articleInReadingList.ReadingListId)
                    .ToListAsync();

                    ArticleInReadingList previousArticle = articlesInReadingListToEdit.FirstOrDefault(airl => airl.ArticleId == articleInReadingList.PreviousArticleId);
                    if (previousArticle == null) throw new ArgumentException();

                    previousArticle.NextArticleId = null;
                    _appDBContext.ArticlesInReadingLists.Remove(articleInReadingList);
                }
                else // Between two articles
                {
                    articlesInReadingListToEdit = await _appDBContext.ArticlesInReadingLists
                    .Where(airl => airl.ReadingListId == articleInReadingList.ReadingListId)
                    .ToListAsync();

                    ArticleInReadingList nextArticle = articlesInReadingListToEdit.FirstOrDefault(airl => airl.ArticleId == articleInReadingList.NextArticleId);
                    if (nextArticle == null) throw new ArgumentException();

                    nextArticle.PreviousArticleId = null;

                    ArticleInReadingList previousArticle = articlesInReadingListToEdit.FirstOrDefault(airl => airl.ArticleId == articleInReadingList.PreviousArticleId);
                    if (previousArticle == null) throw new ArgumentException();

                    previousArticle.NextArticleId = null;
                    _appDBContext.ArticlesInReadingLists.Remove(articleInReadingList);
                }
            }
            await _appDBContext.SaveChangesAsync();


            _appDBContext.Articles.Remove(article);
            await _appDBContext.SaveChangesAsync();

            return new BooleanResponse { Data = true };
        }
    }
}
