using System.Collections.Generic;
using System.Threading.Tasks;
using api_server.Contract.Requests;
using api_server.Contract.Responses;
using api_server.Data;
using api_server.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace api_server.Handlers
{
    public class EditReadingListHandler : IHandler<EditReadingListRequest, IdResponse>
    {
        private readonly ApplicationDBContext _appDBContext;

        public EditReadingListHandler(ApplicationDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }

        public async Task<IdResponse> Handle(EditReadingListRequest request)
        {
            (int id, string name, List<int> articleIds) = request.ReadingListToEdit;

            bool isUniqueName = await _appDBContext.ReadingLists.AllAsync(rl => rl.Id != id && rl.Name.ToLowerInvariant() != name.ToLowerInvariant());
            if (!isUniqueName) throw new Contract.Exceptions.ArgumentException();

            ReadingList readingListToEdit = await _appDBContext.ReadingLists
               .Include(rl => rl.ArticlesInReadingList)
               .FirstOrDefaultAsync(rl => rl.Id == id);
            if (readingListToEdit == null) throw new Contract.Exceptions.ArgumentException();

            foreach (var articleId in articleIds)
            {
                bool existArticleId = await _appDBContext.Articles.AnyAsync(a => a.Id == articleId);
                if (!existArticleId) throw new Contract.Exceptions.ArgumentException();
            }

            List<ArticleInReadingList> articlesInReadingList = await _appDBContext.ArticlesInReadingLists
                .Where(airl => airl.ReadingListId == id)
                .ToListAsync();

            if (articlesInReadingList.Count() > 0)
            {
                _appDBContext.ArticlesInReadingLists.RemoveRange(articlesInReadingList);
                await _appDBContext.SaveChangesAsync();
            }
            for (int index = 0; index < articleIds.Count; index++)
            {
                ArticleInReadingList newArticleInReadingList = new ArticleInReadingList
                {
                    ArticleId = articleIds[index],
                    ReadingListId = readingListToEdit.Id,
                    PreviousArticleId = index != 0 ? articleIds[index--] : null,
                    NextArticleId = index < articleIds.Count - 1 ? articleIds[index++] : null
                };
                await _appDBContext.ArticlesInReadingLists.AddAsync(newArticleInReadingList);
            }

            await _appDBContext.SaveChangesAsync();

            return new IdResponse { Data = readingListToEdit.Id };
        }
    }
}
