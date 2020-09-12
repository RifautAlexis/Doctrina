using System.Collections.Generic;
using api_server.Contract.DTOs;

namespace api_server.Contract.Responses
{
    public class ArticlesResponse
    {
        public List<ArticleDTO> Articles { get; set; }
    }
}
