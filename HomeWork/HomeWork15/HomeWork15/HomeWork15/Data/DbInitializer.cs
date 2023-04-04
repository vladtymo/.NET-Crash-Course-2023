using HomeWork15.Entities;
using Microsoft.EntityFrameworkCore;

namespace HomeWork15.Data
{

    internal static class DbInitializer
    {
        public static void SeedPositions(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Positions>().HasData(new[]
            {
                new Positions { Id = 1, Name = "Manager" },
                new Positions { Id = 2, Name = "Marketing Specialist" },
                new Positions { Id = 3, Name = "Software Developer" }
            });
        }
        public static void SeedCountries(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Countries>().HasData(new[]
            {
                new Countries() { Id = 1, Name = "Ukraine" },
                new Countries() { Id = 2, Name = "USA" },
                new Countries() { Id = 3, Name = "France" }
            });
        }

        public static void SeedCities(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cities>().HasData(new[]
            {
                new Cities() { Id = 1, Name = "Kyiv", CountryId = 1 },
                new Cities() { Id = 2, Name = "Lviv", CountryId = 1 },
                new Cities() { Id = 3, Name = "Paris", CountryId = 3 },
                new Cities() { Id = 4, Name = "New York", CountryId = 2 },
            });
        }

        public static void SeedShops(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Shops>().HasData(new[]
            {
                new Shops() { Id = 1, Name = "Supermarket", Address = "Kyiv, Pushkinska 2", CityId = 1, PartingArea = 1000 },
                new Shops() { Id = 2, Name = "Fruit Store", Address = "Lviv, Shevchenka 20", CityId = 2, PartingArea = 500 },
                new Shops() { Id = 3, Name = "Tech Store", Address = "Paris, Street 27", CityId = 3, PartingArea = 100 }
            });
        }

        public static void SeedProducts(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Products>().HasData(new[]
            {
                new Products() { Id = 1, Name = "Milk", Price = 2.5m, Discount = 0.1f, CategoryId = 1, Quantity = 50, IsInStock = true },
                new Products() { Id = 2, Name = "Bread",Price = 1.2m, Discount = 0.05f, CategoryId = 1, Quantity = 100, IsInStock = true },
                new Products() { Id = 3, Name = "Eggs", Price = 3.0m, Discount = 0, CategoryId = 1, Quantity = 30, IsInStock = false }
            });
        }

        public static void SeedCategories(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categories>().HasData(new[]
            {
            new Categories() { Id = 1, Name = "Dairy Products" },
            new Categories() { Id = 2, Name = "Meat Products" },
            new Categories() { Id = 3, Name = "Fruits Products" }
        });
        }
        public static void SeedWorkers(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Workers>().HasData(new[]
            {
        new Workers { Id = 1, Name = "John", Surname = "Doe", Salary = 3000, Email = "email1@example.com", PhoneNumber = "+380930521032", PositionId = 1, ShopId = 1 },
        new Workers { Id = 2, Name = "Jane", Surname = "Doe", Salary = 2500, Email = "email2@example.com", PhoneNumber = "+380930221022", PositionId = 2, ShopId = 1 },
        new Workers { Id = 3, Name = "Bob", Surname = "Smith", Salary = 2000, Email = "email3@example.com", PhoneNumber = "+380930621031", PositionId = 3, ShopId = 2 }
        });
        }
    }
}



