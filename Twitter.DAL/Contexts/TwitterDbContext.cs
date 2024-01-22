using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Twitter.Core.Entities;

namespace Twitter.DAL.Contexts
{
    public class TwitterDbContext : DbContext
    {
        public TwitterDbContext(DbContextOptions opt) : base(opt){}
        public DbSet<Topic> Topics { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }

    }
}
