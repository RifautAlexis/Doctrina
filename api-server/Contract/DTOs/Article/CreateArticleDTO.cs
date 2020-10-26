﻿using System.Collections.Generic;

namespace api_server.Contract.DTOs
{
    public class CreateArticleDTO
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Description { get; set; }
        public List<int> TagIds { get; set; }

        internal void Deconstruct(out string title, out string content, out string description, out List<int> tagIds)
        {
            title = Title;
            content = Content;
            description = Description;
            tagIds = TagIds;
        }
    }
}