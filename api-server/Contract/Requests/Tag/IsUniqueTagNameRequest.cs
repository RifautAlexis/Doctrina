using Microsoft.AspNetCore.Mvc;
using api_server.Contract.DTOs;

namespace api_server.Contract.Requests
{
    public class IsUniqueTagNameRequest
    {
        [FromBody]
        public IsUniqueTagNameDTO IsUniqueTagNameDTO { get; set; }
    }
}
