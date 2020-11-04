using System.Collections.Generic;
using System.Threading.Tasks;
using api_server.Contract.Mappers;
using api_server.Contract.Requests;
using api_server.Contract.Responses;
using api_server.Data;
using api_server.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace api_server.Handlers
{
    public class GetAllTagHandler : IHandler<GetAllTagRequest, TagsResponse>
    {
        private readonly ApplicationDBContext _appDBContext;

        public GetAllTagHandler(ApplicationDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }

        public async Task<TagsResponse> Handle(GetAllTagRequest request)
        {
            List<Tag> tags = await _appDBContext.Tags.ToListAsync();

            return new TagsResponse { Data = tags.ToDTOs() };
        }
    }
}
