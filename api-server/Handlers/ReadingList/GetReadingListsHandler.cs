using System.Collections.Generic;
using System.Threading.Tasks;
using api_server.Contract.Requests;
using api_server.Contract.Responses;
using api_server.Data;
using api_server.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using api_server.Contract.DTOs;
using api_server.Contract.Mappers;

namespace api_server.Handlers
{
    public class GetReadingListsHandler : IHandler<GetReadingListsRequest, ReadingListsResponse>
    {
        private readonly ApplicationDBContext _appDBContext;

        public GetReadingListsHandler(ApplicationDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }

        public async Task<ReadingListsResponse> Handle(GetReadingListsRequest request)
        {
            List<ReadingList> readingLists = await _appDBContext.ReadingLists
                .Include(rl => rl.ArticlesInReadingList)
                .ToListAsync();

            if (readingLists.Count == 0) return new ReadingListsResponse { Data = new List<ReadingListDTO>() };

            List<ReadingListDTO> readingListsDTO = readingLists.ToDTOs();

            return new ReadingListsResponse { Data = readingListsDTO };
        }
    }
}
