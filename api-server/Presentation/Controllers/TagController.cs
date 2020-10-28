using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using api_server.Contract.Responses;
using api_server.Contract.Requests;
using api_server.Handlers;

namespace api_server.Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class TagController : Controller
    {

        [HttpGet]
        [AllowAnonymous]
        [Route("")]
        public async Task<TagsResponse> GetAll(GetAllTagRequest request, [FromServices] IHandler<GetAllTagRequest, TagsResponse> handler)
        {
            return await handler.Handle(request);
        }
    }
}
