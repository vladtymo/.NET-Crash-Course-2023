using Exam.Database.Enitites;
using Exam.EntityFramework.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Exam.EntityFramework
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<GoodsEntity> Goods { get; set; }
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<SupermarketEntity> Supermarkets { get; set; }
        public DbSet<CheckEntity> Checks { get; set; }

        public ApplicationDbContext()
        {
            Database.Migrate();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Database=SupermarketDb;Trusted_Connection=True;Encrypt=false");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new GoodsConfigurations());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new SupermarketConfiguration());
            modelBuilder.ApplyConfiguration(new CheckConfiguration());
        }
    }
}