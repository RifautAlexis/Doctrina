using System.Threading.Tasks;
using api_server.Contract.Requests;
using api_server.Contract.Responses;
using api_server.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using api_server.Contract.Exceptions;

namespace api_server.Handlers
{
    public class IsUniqueTitleHandler : IHandler<IsUniqueTitleRequest, BooleanResponse>
    {
        private readonly ApplicationDBContext _appDBContext;

        public IsUniqueTitleHandler(ApplicationDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }

        public async Task<BooleanResponse> Handle(IsUniqueTitleRequest request)
        {
            throw new NotFoundException();

            var titles = await _appDBContext.Articles.Select(a => a.Title).ToListAsync();
            bool isUniqueTitle = titles.All(title => title.ToLowerInvariant() != request.isUniqueTitleDTO.Title.ToLowerInvariant());

            return new BooleanResponse { Value = isUniqueTitle };
        }
    }
}
