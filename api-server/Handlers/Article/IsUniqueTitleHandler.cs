using System.Threading.Tasks;
using api_server.Contract.Requests;
using api_server.Contract.Responses;
using api_server.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;

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
            bool isUniqueTitle = await _appDBContext.Articles
                .Select(a => a.Title != request.Title)
                .FirstOrDefaultAsync();

            return new BooleanResponse { Response = isUniqueTitle };
        }
    }
}
