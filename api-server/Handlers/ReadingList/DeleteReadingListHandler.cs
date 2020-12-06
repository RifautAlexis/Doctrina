using System.Threading.Tasks;
using api_server.Contract.Requests;
using api_server.Contract.Responses;
using api_server.Data;
using api_server.Data.Models;
using api_server.Contract.Exceptions;

namespace api_server.Handlers
{
    public class DeleteReadingListHandler : IHandler<DeleteReadingListRequest, BooleanResponse>
    {
        private readonly ApplicationDBContext _appDBContext;

        public DeleteReadingListHandler(ApplicationDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }

        public async Task<BooleanResponse> Handle(DeleteReadingListRequest request)
        {
            ReadingList readingList = await _appDBContext.ReadingLists
                .FindAsync(request.Id);

            if (readingList == null) throw new NotFoundException();

            _appDBContext.ReadingLists.Remove(readingList);
            await _appDBContext.SaveChangesAsync();

            return new BooleanResponse { Data = true };
        }
    }
}
