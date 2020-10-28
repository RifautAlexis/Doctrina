using api_server.Data.Models;
using api_server.Contract.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace api_server.Contract.Mappers
{
    public static class TagMapper
    {
        public static TagDTO ToDTO(this Tag data)
        {
            if (data == null) return null;

            return new TagDTO
            {
                Id = data.Id,
                Name = data.Name,
                CreatedAt = data.CreatedAt,
                UpdatedAt = data.UpdatedAt
            };
        }

        public static List<TagDTO> ToDTOs(this List<Tag> data)
        {
            return data.Select(t => t.ToDTO()).ToList();
        }

        public static List<TagDTO> ToTagDTOs(this List<TagAttributed> data)
        {
            return data.Select(ta => ta.Tag.ToDTO()).ToList();
        }
    }
}
