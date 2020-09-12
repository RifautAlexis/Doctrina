using Microsoft.AspNetCore.Mvc;

namespace api_server.Contract.Requests
{
    public class IsUniqueTitleRequest
    {
        [FromBody]
        public string Title { get; set; }
    }
}
