using System.Linq;
using api_server.Contract.Responses;
using api_server.Data.Models;
using api_server.Contract.DTOs;
using System.Collections.Generic;
using System;

namespace api_server.Contract.Mappers
{
    public static class ArticleMapper
    {
        public static ArticleDTO ToDTO(this Article data)
        {
            if (data == null) return null;

            return new ArticleDTO
            {
                Id = data.Id,
                Title = data.Title,
                Content = data.Content,
                Description = data.Description,
                Author = data.Author.ToDTO(),
                Tags = data.Tags.ToList().ToTagDTOs(),
                CreatedAt = data.CreatedAt,
                UpdatedAt = data.UpdatedAt
            };
        }

        public static List<ArticleDTO> ToDTOs(this List<Article> data)
        {
            return data.Select(article => article.ToDTO()).ToList();
        }
    }
}