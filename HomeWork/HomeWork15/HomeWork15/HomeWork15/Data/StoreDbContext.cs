using HomeWork15.Entities;
using Microsoft.EntityFrameworkCore;

namespace HomeWork15.Data
{
    public class StoreDbContext : DbContext
    {
        public StoreDbContext()
        {
            //this.Database.EnsureDeleted();
            // create database if not exists
            this.Database.EnsureCreated();
        }

        public DbSet<Categories> Categories { get; set; }
        public DbSet<Cities> Cities { get; set; }
        public DbSet<Countries> Countries { get; set; }
        public DbSet<Positions> Positions { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Shops> Shops { get; set; }
        public DbSet<Workers> Workers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            // TODO: move conn str to a app settigns/configuration file
            // connection string contains all necessary info for connect to the db
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=master1;Trusted_Connection=True;Encrypt=false");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // data initialization
            DbInitializer.SeedPositions(modelBuilder);
            DbInitializer.SeedCountries(modelBuilder);
            DbInitializer.SeedCities(modelBuilder);
            DbInitializer.SeedShops(modelBuilder);
            DbInitializer.SeedProducts(modelBuilder);
            DbInitializer.SeedCategories(modelBuilder);
            DbInitializer.SeedWorkers(modelBuilder); 
            // Cities to Countries (Many-to-One)
            modelBuilder.Entity<Cities>()
                .HasOne(c => c.Country)
                .WithMany(c => c.Cities)
                .HasForeignKey(c => c.CountryId);


            // Shops to Cities (Many-to-One)
            modelBuilder.Entity<Shops>()
                .HasOne(s => s.City)
                .WithMany(c => c.Shops)
                .HasForeignKey(s => s.CityId);





           // Shops to Products (Many-to-Many)
               modelBuilder.Entity<Shops>()
               .HasMany(s => s.Products)
               .WithMany(p => p.Shops);


            // Products to Categories (Many-to-One)
            modelBuilder.Entity<Products>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId);


            // Workers to Shops (Many-to-One)
            modelBuilder.Entity<Workers>()
                .HasOne(w => w.Shop)
                .WithMany(s => s.Workers)
                .HasForeignKey(w => w.ShopId);


            // Positions to Workers (One-to-Many)
            modelBuilder.Entity<Positions>()
                .HasMany(p => p.Workers)
                .WithOne(w => w.Position)
                .HasForeignKey(w => w.PositionId);




        }


    }
}