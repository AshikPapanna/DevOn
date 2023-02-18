using Microsoft.EntityFrameworkCore;
using DevOn.Business.Models;
using System.Reflection.Metadata;

namespace DevOn.DB
{
    public class DevOnDbContext:DbContext
    {
        public DevOnDbContext(DbContextOptions<DevOnDbContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().UseTpcMappingStrategy().ToTable("Products");
             modelBuilder.Entity<Category>().UseTpcMappingStrategy();

        }
    }

}