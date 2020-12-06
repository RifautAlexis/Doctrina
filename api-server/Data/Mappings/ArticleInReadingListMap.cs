using api_server.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace api_server.Data.Mappings
{
    public class ArticleInReadingListMap
    {

        public ArticleInReadingListMap(EntityTypeBuilder<ArticleInReadingList> entityBuilder)
        {
            entityBuilder.HasKey(airl => airl.Id);

            entityBuilder.Property(airl => airl.CreatedAt).IsRequired();
        }
    }
}
