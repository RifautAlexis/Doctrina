using api_server.Contract.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace api_server.Contract.Requests
{
    public class CreateReadingListRequest
    {
        [FromBody]
        public CreateReadingListDTO NewReadingList { get; set; }
    }
}
