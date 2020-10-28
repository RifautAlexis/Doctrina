namespace api_server.Data.Models
{
    public class TagAttributed : BaseEntity
    {
        public virtual Tag Tag { get; set; }
        public virtual Article Article { get; set; }

        /*****/

        public int TagId { get; set; }
        public int ArticleId { get; set; }
    }
}
