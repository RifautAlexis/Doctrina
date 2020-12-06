using System.Threading.Tasks;
using api_server.Contract.Requests;
using api_server.Contract.Responses;
using api_server.Data;
using api_server.Data.Models;
using Microsoft.EntityFrameworkCore;
using api_server.Contract.Exceptions;

namespace api_server.Handlers
{
    public class CreateTagHandler : IHandler<CreateTagRequest, IdResponse>
    {
        private readonly ApplicationDBContext _appDBContext;

        public CreateTagHandler(ApplicationDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }

        public async Task<IdResponse> Handle(CreateTagRequest request)
        {
            string name = request.NewTag.Name;

            bool isUniqueName = await _appDBContext.Tags.AllAsync(t => t.Name.ToLowerInvariant() != name.ToLowerInvariant());
            if (!isUniqueName) throw new ArgumentException();

            Tag tagToAdd = new Tag
            {
                Name = name
            };

            await _appDBContext.SaveChangesAsync();

            return new IdResponse { Data = tagToAdd.Id };
        }
    }
}
