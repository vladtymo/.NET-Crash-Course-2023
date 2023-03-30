using _23_ef_base.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace _23_ef_base.Data
{
    internal static class DbInitializer
    {
        public static void SeedCountries(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().HasData(new[]
            {
                new Country() { Id = 1, Name = "Ukraine" },
                new Country() { Id = 2, Name = "France" },
                new Country() { Id = 3, Name = "USA" },
                new Country() { Id = 4, Name = "Italy" },
                new Country() { Id = 5, Name = "United Kindom" },
            });
        }

        public static void SeedAuthors(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(new[]
            {
                new Author()
                {
                    Id = 1,
                    FirstName = "Ivan",
                    LastName = "Franko",
                    CountryId = 1,
                },
                new Author()
                {
                    Id = 2,
                    FirstName = "Taras",
                    LastName = "Shevchenko",
                    CountryId = 1,
                },
                new Author()
                {
                    Id = 3,
                    FirstName = "Mykola",
                    LastName = "Gogol",
                    CountryId = 1,
                },
                new Author()
                {
                    Id = 4,
                    FirstName = "Mark",
                    LastName = "Twain",
                    CountryId = 3,
                },
                new Author()
                {
                    Id = 5,
                    FirstName = "Stephen",
                    LastName = "King",
                    CountryId = 3,
                }
            });
        }
    }
}
