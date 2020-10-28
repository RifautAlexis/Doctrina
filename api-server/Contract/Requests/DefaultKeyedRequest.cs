using Microsoft.AspNetCore.Mvc;

namespace api_server.Contract.Requests
{
    public class DefaultKeyedRequest
    {
        [FromRoute]
        public int Id { get; set; }
    }
}
