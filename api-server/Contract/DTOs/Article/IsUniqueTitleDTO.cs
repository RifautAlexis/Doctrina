namespace api_server.Contract.DTOs
{
    public class IsUniqueTitleDTO
    {
        public string Title { get; set; }
        public int? ArticleId { get; set; }

        internal void Deconstruct(out string title, out int? articleId)
        {
            title = Title;
            articleId = ArticleId;
        }
    }
}
