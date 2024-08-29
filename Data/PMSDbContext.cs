using Microsoft.EntityFrameworkCore;
using PMS.API.Models;


namespace PMS.API.Data
{
    public class PMSDbContext : DbContext
    {
        public PMSDbContext(DbContextOptions options) : base(options) { }


        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.Id).HasColumnType("uuid");
            });

            base.OnModelCreating(modelBuilder);
        }


    }
}
