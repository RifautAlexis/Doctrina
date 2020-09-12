using System.Collections.Generic;
using api_server.Data.Models;
using System;

namespace api_server.Contract.DTOs
{
    public class ArticleDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Description { get; set; }
        public UserDTO Author { get; set; }
        public List<TagDTO> Tags { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
