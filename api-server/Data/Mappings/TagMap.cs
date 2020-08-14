using api_server.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace api_server.Data.Mapping
{
    public class TagMap
    {

        public TagMap(EntityTypeBuilder<Tag> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);

            entityBuilder.Property(t => t.Name).IsRequired();
            entityBuilder.HasIndex(t => t.Name).IsUnique();

            entityBuilder.Property(t => t.CreatedAt).IsRequired();
            entityBuilder.Property(t => t.UpdatedAt).IsRequired();

            /*****/

            entityBuilder.HasMany(t => t.TagsAttributed).WithOne(ta => ta.Tag).HasForeignKey(ta => ta.TagId);
        }
    }
}
