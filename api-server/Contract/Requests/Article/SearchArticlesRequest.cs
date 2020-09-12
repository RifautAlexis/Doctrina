using Microsoft.AspNetCore.Mvc;

namespace api_server.Contract.Requests
{
    public class SearchArticlesRequest
    {
        [FromQuery]
        public string ToSearch { get; set; }
    }
}
