using System.Threading.Tasks;
using api_server.Contract.Responses;
using api_server.Contract.Requests;
using api_server.Data;
using api_server.Data.Models;
using api_server.Contract.Exceptions;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace api_server.Handlers
{
    public class DeleteTagHandler : IHandler<DeleteTagRequest, BooleanResponse>
    {
        private readonly ApplicationDBContext _appDBContext;

        public DeleteTagHandler(ApplicationDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }

        public async Task<BooleanResponse> Handle(DeleteTagRequest request)
        {
            Tag tag = await _appDBContext.Tags
                .FindAsync(request.Id);

            if (tag == null) throw new NotFoundException();

            List<TagAttributed> tagsAttributed = await _appDBContext.TagsAttributed
                .Where(ta => ta.Id == tag.Id)
                .ToListAsync();

            _appDBContext.TagsAttributed.RemoveRange(tagsAttributed);
            await _appDBContext.SaveChangesAsync();

            _appDBContext.Tags.Remove(tag);
            await _appDBContext.SaveChangesAsync();

            return new BooleanResponse { Data = true };
        }
    }
}
