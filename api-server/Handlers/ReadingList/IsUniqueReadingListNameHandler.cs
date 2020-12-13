using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using api_server.Contract.Requests;
using api_server.Contract.Responses;
using api_server.Data;
using api_server.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using api_server.Contract.Exceptions;

namespace api_server.Handlers
{
    public class IsUniqueReadingListNameHandler : IHandler<IsUniqueReadingListNameRequest, BooleanResponse>
    {
        private readonly ApplicationDBContext _appDBContext;

        public IsUniqueReadingListNameHandler(ApplicationDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }

        public async Task<BooleanResponse> Handle(IsUniqueReadingListNameRequest request)
        {

            var (name, readingListId) = request.IsUniqueReadingListNameDTO;

            bool isUniqueName = false;

            if (readingListId.HasValue)
            {
                isUniqueName = await _appDBContext.ReadingLists.AllAsync(rl => rl.Id != readingListId && rl.Name.ToLower() != name.ToLower());
            }
            else
            {
                isUniqueName = await _appDBContext.ReadingLists.AllAsync(rl => rl.Name.ToLower() != name.ToLower());
            }

            return new BooleanResponse { Data = isUniqueName };
        }
    }
}
