using api_server.Contract.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace api_server.Contract.Requests
{
    public class IsUniqueReadingListNameRequest
    {
        [FromBody]
        public IsUniqueReadingListNameDTO IsUniqueReadingListNameDTO { get; set; }
    }
}
