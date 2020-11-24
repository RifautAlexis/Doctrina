using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using api_server.Contract.Requests;
using api_server.Handlers;
using api_server.Contract.Responses;
using api_server.Data;
using api_server.Presentation;

namespace api_server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class ArticleController : Controller
    {
        [HttpGet]
        [AllowAnonymous]
        [Route("search")]
        public async Task<ArticlesResponse> Search(SearchArticlesRequest request, [FromServices] IHandler<SearchArticlesRequest, ArticlesResponse> handler)
        {
            return await handler.Handle(request);
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("{id}")]
        public async Task<ArticleResponse> GetById(GetArticleByIdRequest request, [FromServices] IHandler<GetArticleByIdRequest, ArticleResponse> handler)
        {
            return await handler.Handle(request);
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("")]
        public async Task<ArticlesResponse> GetAll(GetAllArticleRequest request, [FromServices] IHandler<GetAllArticleRequest, ArticlesResponse> handler)
        {
            return await handler.Handle(request);
        }

        [HttpPost]
        [Authorized(Role.Admin)]
        [Route("isUniqueTitle")]
        public async Task<BooleanResponse> IsUniqueTitle(IsUniqueTitleRequest request, [FromServices] IHandler<IsUniqueTitleRequest, BooleanResponse> handler)
        {
            return await handler.Handle(request);
        }

        [HttpPost]
        [Authorized(Role.Admin)]
        [Route("")]
        public async Task<IdResponse> CreateArticle(CreateArticleRequest request, [FromServices] IHandler<CreateArticleRequest, IdResponse> handler)
        {
            return await handler.Handle(request);
        }

        [HttpPut]
        [Authorized(Role.Admin)]
        [Route("{id}")]
        public async Task<IdResponse> EditArticle(EditArticleRequest request, [FromServices] IHandler<EditArticleRequest, IdResponse> handler)
        {
            return await handler.Handle(request);
        }

        [HttpDelete]
        [Authorized(Role.Admin)]
        [Route("{id}")]
        public async Task<BooleanResponse> DeleteArticle(DeleteArticleRequest request, [FromServices] IHandler<DeleteArticleRequest, BooleanResponse> handler)
        {
            return await handler.Handle(request);
        }
    }
}
