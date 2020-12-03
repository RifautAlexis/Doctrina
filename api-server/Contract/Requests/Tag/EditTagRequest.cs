using api_server.Contract.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace api_server.Contract.Requests
{
    public class EditTagRequest
    {
        [FromBody]
        public EditTagDTO TagToEdit { get; set; }
    }
}
