using api_server.Contract.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace api_server.Contract.Requests
{
    public class SigninRequest
    {
        [FromBody]
        public SigninDTO SigninDTO { get; set; }
    }
}
