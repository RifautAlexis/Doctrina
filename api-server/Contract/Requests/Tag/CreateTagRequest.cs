using api_server.Contract.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace api_server.Contract.Requests
{
    public class CreateTagRequest
    {
        [FromBody]
        public CreateTagDTO NewTag { get; set; }
    }
}
