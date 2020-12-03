using api_server.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace api_server.Data.Mappings
{
    public class ReadingListMap
    {

        public ReadingListMap(EntityTypeBuilder<ReadingList> entityBuilder)
        {
            entityBuilder.HasKey(rl => rl.Id);

            entityBuilder.Property(rl => rl.Title).IsRequired();
            entityBuilder.HasIndex(rl => rl.Title).IsUnique();

            /*****/

            entityBuilder.HasMany(rl => rl.Articles).WithOne(a => a.ReadingList).HasForeignKey(rl => rl.ReadingListId);
        }
    }
}
