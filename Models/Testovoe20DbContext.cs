using Microsoft.EntityFrameworkCore;

namespace Testovoe2._0.Models
{
    public class Testovoe20DbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Channel> Channels { get; set; }
        public DbSet<Guid> Guids { get; set; }
        public DbSet<Items> Items { get; set; }
        public DbSet<LinksCategoryItems> LinksCategoryItems { get; set; }
        public Testovoe20DbContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=D:/Testapppp.sqlite");
        }
    }
}


