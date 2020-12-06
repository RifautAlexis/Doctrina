using System.Collections.Generic;
using System.Threading.Tasks;
using api_server.Contract.Requests;
using api_server.Contract.Responses;
using api_server.Data;
using api_server.Data.Models;
using Microsoft.EntityFrameworkCore;
using api_server.Contract.Exceptions;
using System.Linq;
using System;

namespace api_server.Handlers
{
    public class EditArticleHandler : IHandler<EditArticleRequest, IdResponse>
    {
        private readonly ApplicationDBContext _appDBContext;

        public EditArticleHandler(ApplicationDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }

        public async Task<IdResponse> Handle(EditArticleRequest request)
        {
            (int id, string title, string content, string description, List<int> tagIds) = request.ArticleToEdit;

            bool isUniqueTitle = await _appDBContext.Articles.AllAsync(a => a.Id != id && a.Title.ToLowerInvariant() != title.ToLowerInvariant());
            if (!isUniqueTitle) throw new Contract.Exceptions.ArgumentException();

            foreach (var tagId in tagIds)
            {
                bool existTagId = await _appDBContext.Tags.AnyAsync(a => a.Id == tagId);
                if (!existTagId) throw new Contract.Exceptions.ArgumentException();
            }

            Article articleToEdit = await _appDBContext.Articles
                .Where(a => a.Id == id)
                .Include(a => a.Tags)
                .FirstOrDefaultAsync();
            if (articleToEdit == null) throw new NotFoundException();

            articleToEdit.Title = title;
            articleToEdit.Description = description;
            articleToEdit.Content = content;

            foreach (var tagAttributed in articleToEdit.Tags)
            {
                if (!tagIds.Contains(tagAttributed.TagId))
                {
                    articleToEdit.Tags.Remove(tagAttributed);
                }
            }
            foreach (var tagId in tagIds)
            {
                if (!articleToEdit.Tags.Any(ta => ta.TagId == tagId))
                {
                    TagAttributed tagAttributedToAdd = new TagAttributed
                    {
                        TagId = tagId,
                        ArticleId = articleToEdit.Id
                    };
                    await _appDBContext.TagsAttributed.AddAsync(tagAttributedToAdd);
                }
            }
            articleToEdit.UpdatedAt = DateTime.Now;

            await _appDBContext.SaveChangesAsync();

            return new IdResponse { Data = articleToEdit.Id };
        }
    }
}
