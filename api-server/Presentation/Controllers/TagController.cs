using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using api_server.Contract.Responses;
using api_server.Contract.Requests;
using api_server.Handlers;
using api_server.Data;

namespace api_server.Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class TagController : Controller
    {

        [HttpGet]
        [Authorized(Role.Admin)]
        [Route("")]
        public async Task<TagsResponse> GetAll(GetAllTagRequest request, [FromServices] IHandler<GetAllTagRequest, TagsResponse> handler)
        {
            return await handler.Handle(request);
        }

        [HttpPost]
        [Authorized(Role.Admin)]
        [Route("")]
        public async Task<IdResponse> CreateArticle(CreateTagRequest request, [FromServices] IHandler<CreateTagRequest, IdResponse> handler)
        {
            return await handler.Handle(request);
        }

        [HttpDelete]
        [Authorized(Role.Admin)]
        [Route("{id}")]
        public async Task<BooleanResponse> DeleteArticle(DeleteTagRequest request, [FromServices] IHandler<DeleteTagRequest, BooleanResponse> handler)
        {
            return await handler.Handle(request);
        }

        [HttpPost]
        [Authorized(Role.Admin)]
        [Route("isUniqueTagName")]
        public async Task<BooleanResponse> IsUniqueTagName(IsUniqueTagNameRequest request, [FromServices] IHandler<IsUniqueTagNameRequest, BooleanResponse> handler)
        {
            return await handler.Handle(request);
        }

        [HttpPut]
        [Authorized(Role.Admin)]
        [Route("{id}")]
        public async Task<IdResponse> EditTag(EditTagRequest request, [FromServices] IHandler<EditTagRequest, IdResponse> handler)
        {
            return await handler.Handle(request);
        }
    }
}
