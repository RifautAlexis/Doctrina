using api_server.Data.Models;
using api_server.Data.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using System.Linq;
using System;
using System.Threading;

namespace api_server.Data
{
    public class ApplicationDBContext : DbContext
    {
        private readonly IConfiguration _appSettings;

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options, IConfiguration config) : base(options)
        {
            _appSettings = config;
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<TagAttributed> TagsAttributed { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            new UserMap(modelBuilder.Entity<User>());
            new ArticleMap(modelBuilder.Entity<Article>());
            new TagMap(modelBuilder.Entity<Tag>());
            new TagAttributedMap(modelBuilder.Entity<TagAttributed>());

            modelBuilder.Seed(_appSettings);
        }

        public override int SaveChanges()
        {
            AddTimestamps();
            return base.SaveChanges();
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            AddTimestamps();
            return await base.SaveChangesAsync(cancellationToken);
        }

        private void AddTimestamps()
        {
            var entities = ChangeTracker.Entries()
                .Where(x => x.Entity is BaseEntity && (x.State == EntityState.Added || x.State == EntityState.Modified));

            foreach (var entity in entities)
            {
                var now = DateTime.UtcNow; // current datetime

                if (entity.State == EntityState.Added)
                {
                    ((BaseEntity)entity.Entity).CreatedAt = now;
                }
                ((BaseEntity)entity.Entity).UpdatedAt = now;
            }
        }

    }
}