using api_server.Contract.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace api_server.Contract.Requests
{
    public class EditReadingListRequest
    {
        [FromBody]
        public EditReadingListDTO ReadingListToEdit { get; set; }
    }
}
