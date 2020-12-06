using api_server.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace api_server.Data.Mapping
{
    public class UserMap
    {

        public UserMap(EntityTypeBuilder<User> entityBuilder)
        {
            entityBuilder.HasKey(u => u.Id);

            entityBuilder.Property(u => u.Username).IsRequired();
            entityBuilder.HasIndex(u => u.Username).IsUnique();

            entityBuilder.Property(u => u.Email).IsRequired();
            entityBuilder.HasIndex(u => u.Email).IsUnique();

            entityBuilder.Property(u => u.Role).IsRequired();
            entityBuilder.Property(u => u.PasswordHash).IsRequired();

            entityBuilder.Property(u => u.CreatedAt).IsRequired();

            /*****/

            entityBuilder.HasMany(u => u.Articles).WithOne(a => a.Author).HasForeignKey(a => a.AuthorId);
        }
    }
}
