using System.Collections.Generic;

namespace api_server.Contract.DTOs
{
    public class ReadingListDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<int> ArticleIds { get; set; }
    }
}
