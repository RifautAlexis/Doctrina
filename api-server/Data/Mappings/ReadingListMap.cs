using api_server.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace api_server.Data.Mappings
{
    public class ReadingListMap
    {

        public ReadingListMap(EntityTypeBuilder<ReadingList> entityBuilder)
        {
            entityBuilder.HasKey(rl => rl.Id);

            entityBuilder.Property(rl => rl.Name).IsRequired();
            entityBuilder.HasIndex(rl => rl.Name).IsUnique();

            entityBuilder.Property(rl => rl.Description).IsRequired();

            entityBuilder.Property(a => a.CreatedAt).IsRequired();

            /*****/

            entityBuilder.HasMany(rl => rl.ArticlesInReadingList).WithOne(airl => airl.ReadingList).HasForeignKey(rl => rl.ReadingListId);
        }
    }
}
