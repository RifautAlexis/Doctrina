using api_server.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace api_server.Data.Mapping
{
    public class TagAttributedMap
    {

        public TagAttributedMap(EntityTypeBuilder<TagAttributed> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);

            entityBuilder.Property(t => t.CreatedAt).IsRequired();
            entityBuilder.Property(t => t.UpdatedAt).IsRequired();
        }
    }
}
