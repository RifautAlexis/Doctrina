using System.Collections.Generic;
using System.Linq;
using api_server.Contract.DTOs;
using api_server.Data.Models;

namespace api_server.Contract.Mappers
{
    public static class ReadingListMapper
    {
        public static ReadingListDTO ToDTO(this ReadingList data)
        {
            if (data == null) return null;

            return new ReadingListDTO
            {
                Id = data.Id,
                Name = data.Name,
                Description = data.Description,
                ArticleIds = OrderArticle(data.ArticlesInReadingList.ToList())
            };
        }

        public static List<ReadingListDTO> ToDTOs(this List<ReadingList> data)
        {
            return data.Select(readingList => readingList.ToDTO()).ToList();
        }

        private static List<int> OrderArticle(List<ArticleInReadingList> articleInReadingList)
        {
            if (articleInReadingList.Count == 0) return new List<int>();

            List<int> articleIdsOrdered = new List<int>();

            articleIdsOrdered.Add(
                articleInReadingList
                .Where(airl => airl.PreviousArticleId == null)
                .Select(airl => airl.Id)
                .FirstOrDefault()
            );


            for (int index = 1; index < articleInReadingList.Count; index++)
            {
                articleIdsOrdered.Add(
                    articleInReadingList
                    .Where(airl => airl.PreviousArticleId != null && airl.PreviousArticleId == articleIdsOrdered[index - 1])
                    .Select(airl => airl.Id)
                    .FirstOrDefault());
            }

            return null;
        }
    }
}
