using System.Threading.Tasks;
using api_server.Contract.Requests;
using api_server.Contract.Responses;
using api_server.Data;
using Microsoft.EntityFrameworkCore;

namespace api_server.Handlers
{
    public class IsUniqueTagNameHandler : IHandler<IsUniqueTagNameRequest, BooleanResponse>
    {
        private readonly ApplicationDBContext _appDBContext;

        public IsUniqueTagNameHandler(ApplicationDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }

        public async Task<BooleanResponse> Handle(IsUniqueTagNameRequest request)
        {
            var (name, tagId) = request.IsUniqueTagNameDTO;

            bool isUniqueTagName = false;

            if (tagId.HasValue)
            {
                isUniqueTagName = await _appDBContext.Tags.AllAsync(t => t.Id != tagId && !t.Name.ToLower().Equals(name.ToLower()));
            }
            else
            {
                isUniqueTagName = await _appDBContext.Tags.AllAsync(t => !t.Name.ToLower().Equals(name.ToLower()));
            }

            return new BooleanResponse { Data = isUniqueTagName };
        }
    }
}
