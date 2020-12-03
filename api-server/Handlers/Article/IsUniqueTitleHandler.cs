using System.Threading.Tasks;
using api_server.Contract.Requests;
using api_server.Contract.Responses;
using api_server.Data;
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
            (string title, int? articleId) = request.IsUniqueTitleDTO;

            bool isUniqueTitle = false;

            if (articleId.HasValue)
            {
                isUniqueTitle = await _appDBContext.Articles.AllAsync(a => a.Id != articleId && !a.Title.ToLower().Equals(title.ToLower()));
            }
            else
            {
                isUniqueTitle = await _appDBContext.Articles.AllAsync(a => !a.Title.ToLower().Equals(title.ToLower()));
            }

            return new BooleanResponse { Data = isUniqueTitle };
        }
    }
}
