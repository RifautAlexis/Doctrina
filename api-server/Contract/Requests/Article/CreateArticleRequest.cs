using api_server.Contract.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace api_server.Contract.Requests
{
    public class CreateArticleRequest
    {
        [FromBody]
        public CreateArticleDTO NewArticle { get; set; }
    }
}
