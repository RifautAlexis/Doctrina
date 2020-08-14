using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using api_server.Contract.Requests;
using api_server.Handlers;
using api_server.Contract.Responses;

namespace api_server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class AuthenticationController : Controller
    {
        [HttpPost]
        [AllowAnonymous]
        [Route("signin")]
        public async Task<AuthenticationResponse> Signin(SigninRequest request, [FromServices] IHandler<SigninRequest, AuthenticationResponse> handler)
        {
            return await handler.Handle(request);
        }
    }
}
