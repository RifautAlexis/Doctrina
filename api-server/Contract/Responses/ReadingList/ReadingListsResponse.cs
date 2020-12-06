using System.Collections.Generic;
using api_server.Contract.DTOs;

namespace api_server.Contract.Responses
{
    public class ReadingListsResponse
    {
        public List<ReadingListDTO> Data { get; set; }
    }
}
