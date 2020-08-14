using System.Collections.Generic;

namespace api_server.Data.Models
{
    public class Article : BaseEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }

        /*****/

        public virtual User Author { get; set; }
        public virtual ICollection<TagsAttributed> Tags { get; set; }

        /*****/

        public int AuthorId { get; set; }
    }
}
