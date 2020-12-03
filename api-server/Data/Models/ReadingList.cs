using System.Collections.Generic;

namespace api_server.Data.Models
{
    public class ReadingList : BaseEntity
    {
        public string Title { get; set; }

        /*****/

        public virtual ICollection<Article> Articles { get; set; }
    }
}
