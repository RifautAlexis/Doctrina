using System.Collections.Generic;
using api_server.Contract.DTOs;

namespace api_server.Contract.Responses
{
    public class TagsResponse
    {
        public List<TagDTO> Data { get; set; }
    }
}
