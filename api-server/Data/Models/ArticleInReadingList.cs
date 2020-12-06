namespace api_server.Data.Models
{
    public class ArticleInReadingList : BaseEntity
    {
        public int? PreviousArticleId { get; set; }
        public int? NextArticleId { get; set; }

        /*****/

        public virtual ReadingList ReadingList { get; set; }
        public virtual Article Article { get; set; }

        /*****/

        public int ReadingListId { get; set; }
        public int ArticleId { get; set; }
    }
}
