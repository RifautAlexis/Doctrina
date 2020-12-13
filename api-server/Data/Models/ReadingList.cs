using System.Collections.Generic;

namespace api_server.Data.Models
{
    public class ReadingList : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        /*****/

        public virtual ICollection<ArticleInReadingList> ArticlesInReadingList { get; set; }
    }
}
