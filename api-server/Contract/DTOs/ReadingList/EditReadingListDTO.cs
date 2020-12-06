using System.Collections.Generic;

namespace api_server.Contract.DTOs
{
    public class EditReadingListDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<int> ArticleIds { get; set; }

        internal void Deconstruct(out int id, out string name, out List<int> articleIds)
        {
            id = Id;
            name = Name;
            articleIds = ArticleIds;
        }
    }
}
