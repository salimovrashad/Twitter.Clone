using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Twitter.Core.Entities;
using Twitter.Core.Entities.Common;

namespace Twitter.DAL.Contexts
{
    public class TwitterDbContext : DbContext
    {
        public TwitterDbContext(DbContextOptions opt) : base(opt){}
        public DbSet<Topic> Topics { get; set; }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var entries = ChangeTracker.Entries<BaseEntity>();
            foreach (var entry in entries)
            {
                if (entry.State == EntityState.Added)
                    entry.Entity.CreatedTime = DateTime.UtcNow;
            }
            return base.SaveChangesAsync(cancellationToken);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }

    }
}
