using api_server.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace api_server.Data.Mapping
{
    public class ArticleMap
    {

        public ArticleMap(EntityTypeBuilder<Article> entityBuilder)
        {
            entityBuilder.HasKey(a => a.Id);

            entityBuilder.Property(a => a.Title).IsRequired();
            entityBuilder.HasIndex(a => a.Title).IsUnique();

            entityBuilder.Property(a => a.Content).IsRequired();

            entityBuilder.Property(a => a.Description).IsRequired();

            entityBuilder.Property(a => a.CreatedAt).IsRequired();
            entityBuilder.Property(a => a.UpdatedAt).IsRequired();

            /*****/

            entityBuilder.HasMany(a => a.Tags).WithOne(ta => ta.Article).HasForeignKey(ta => ta.ArticleId);
        }
    }
}
