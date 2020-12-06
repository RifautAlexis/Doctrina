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
using api_server.Contract.DTOs;
using System.Linq;
using api_server.Contract.Mappers;

namespace api_server.Handlers
{
    public class GetReadingListByIdHandler : IHandler<GetReadingListByIdRequest, ReadingListResponse>
    {
        private readonly ApplicationDBContext _appDBContext;

        public GetReadingListByIdHandler(ApplicationDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }

        public async Task<ReadingListResponse> Handle(GetReadingListByIdRequest request)
        {
            int readingListId = request.Id;

            ReadingList readingList = await _appDBContext.ReadingLists
               .Where(rl => rl.Id == readingListId)
               .Include(rl => rl.ArticlesInReadingList)
               .FirstOrDefaultAsync();
            if (readingList == null) throw new Contract.Exceptions.ArgumentException();

            ReadingListDTO readingListDTO = readingList.ToDTO();

            return new ReadingListResponse { Data = readingListDTO };
        }
    }
}
