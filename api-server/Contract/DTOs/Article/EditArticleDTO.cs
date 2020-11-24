using System.Collections.Generic;

namespace api_server.Contract.DTOs
{
    public class EditArticleDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Description { get; set; }
        public List<int> TagIds { get; set; }

        internal void Deconstruct(out int id, out string title, out string content, out string description, out List<int> tagIds)
        {
            id = Id;
            title = Title;
            content = Content;
            description = Description;
            tagIds = TagIds;
        }
    }
}
