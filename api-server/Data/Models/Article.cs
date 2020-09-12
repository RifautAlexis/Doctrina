using System.Collections.Generic;

namespace api_server.Data.Models
{
    public class Article : BaseEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Description { get; set; }

        /*****/

        public virtual User Author { get; set; }
        public virtual ICollection<TagAttributed> Tags { get; set; }

        /*****/

        public int AuthorId { get; set; }
    }
}
