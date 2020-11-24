using Microsoft.AspNetCore.Mvc;
using api_server.Contract.DTOs;

namespace api_server.Contract.Requests
{
    public class IsUniqueTitleRequest
    {
        [FromBody]
        public IsUniqueTitleDTO IsUniqueTitleDTO { get; set; }
        //public string Title { get; set; }
    }
}
