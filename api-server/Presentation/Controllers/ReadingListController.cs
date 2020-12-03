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
    public class ReadingListController : Controller
    {

        //[HttpGet]
        //[Authorized(Role.Admin)]
        //[Route("")]
        //public async Task<TagsResponse> GetAll(GetReadingListsRequest request, [FromServices] IHandler<GetReadingListsRequest, TagsResponse> handler)
        //{
        //    return await handler.Handle(request);
        //}

        //[HttpPost]
        //[Authorized(Role.Admin)]
        //[Route("")]
        //public async Task<IdResponse> CreateReadingList(CreateReadingListRequest request, [FromServices] IHandler<CreateReadingListRequest, IdResponse> handler)
        //{
        //    return await handler.Handle(request);
        //}

        //[HttpPut]
        //[Authorized(Role.Admin)]
        //[Route("{id}")]
        //public async Task<IdResponse> EditReadingList(EditReadingListRequest request, [FromServices] IHandler<EditReadingListRequest, IdResponse> handler)
        //{
        //    return await handler.Handle(request);
        //}

        //[HttpDelete]
        //[Authorized(Role.Admin)]
        //[Route("{id}")]
        //public async Task<BooleanResponse> DeleteReadingList(DeleteReadingListRequest request, [FromServices] IHandler<DeleteReadingListRequest, BooleanResponse> handler)
        //{
        //    return await handler.Handle(request);
        //}
    }
}
