using System.Threading.Tasks;
using api_server.Contract.Requests;
using api_server.Contract.Responses;
using api_server.Data;
using api_server.Data.Models;
using Microsoft.EntityFrameworkCore;
using api_server.Contract.Exceptions;

namespace api_server.Handlers
{
    public class CreateReadingListHandler : IHandler<CreateReadingListRequest, IdResponse>
    {
        private readonly ApplicationDBContext _appDBContext;

        public CreateReadingListHandler(ApplicationDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }

        public async Task<IdResponse> Handle(CreateReadingListRequest request)
        {
            string name = request.NewReadingList.Name;

            bool isUniqueName = await _appDBContext.ReadingLists.AllAsync(rl => !rl.Name.Equals(name));
            if (isUniqueName) throw new ArgumentException();

            ReadingList newReadingList = new ReadingList
            {
                Name = name
            };

            await _appDBContext.ReadingLists.AddAsync(newReadingList);
            await _appDBContext.SaveChangesAsync();

            return new IdResponse { Data = newReadingList.Id };
        }
    }
}
