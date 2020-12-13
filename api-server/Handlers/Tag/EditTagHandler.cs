using System.Collections.Generic;
using System.Threading.Tasks;
using api_server.Contract.Requests;
using api_server.Contract.Responses;
using api_server.Data;
using api_server.Data.Models;
using Microsoft.EntityFrameworkCore;
using api_server.Contract.Exceptions;
using System.Linq;
using System;

namespace api_server.Handlers
{
    public class EditTagHandler : IHandler<EditTagRequest, IdResponse>
    {
        private readonly ApplicationDBContext _appDBContext;

        public EditTagHandler(ApplicationDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }

        public async Task<IdResponse> Handle(EditTagRequest request)
        {
            var (id, name) = request.TagToEdit;

            bool isUniqueTagName = await _appDBContext.Tags.AllAsync(t => t.Id != id && t.Name.ToLowerInvariant() != name.ToLowerInvariant());
            if (!isUniqueTagName) throw new Contract.Exceptions.ArgumentException();

            Tag tagToEdit = await _appDBContext.Tags
                .Where(t => t.Id == id)
                .FirstOrDefaultAsync();

            if (tagToEdit == null) throw new NotFoundException();

            tagToEdit.Name = name;

            tagToEdit.UpdatedAt = DateTime.Now;

            await _appDBContext.SaveChangesAsync();

            return new IdResponse { Data = tagToEdit.Id };
        }
    }
}
