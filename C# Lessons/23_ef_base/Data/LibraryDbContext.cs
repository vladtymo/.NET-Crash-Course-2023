using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_ef_base.Data
{
    internal class LibraryDbContext : DbContext
    {
        public LibraryDbContext()
        {
            //this.Database.EnsureDeleted();
            // create database if not exists
            this.Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            // connection string contains all neccessary info for connect to the db
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Library_DB_Crash;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // data initialization
            modelBuilder.Entity<Author>().HasData(new[]
            {
                new Author()
                {
                    Id = 1,
                    FirstName = "Ivan",
                    LastName = "Franko",
                    Country = "Ukraine"
                },
                new Author()
                {
                    Id = 2,
                    FirstName = "Taras",
                    LastName = "Shevchenko",
                    Country = "Ukraine"
                },
                new Author()
                {
                    Id = 3,
                    FirstName = "Mykola",
                    LastName = "Gogol",
                    Country = "Ukraine"
                },
                new Author()
                {
                    Id = 4,
                    FirstName = "Mark",
                    LastName = "Twain",
                    Country = "USA"
                },
                new Author()
                {
                    Id = 5,
                    FirstName = "Stephen",
                    LastName = "King",
                    Country = "USA"
                }
            });
        }

        // ---------- data collections (tables) ----------
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
    }

    // ---------- entities ----------
    class Book
    {
        // properties (columns)
        public int Id { get; set; }         // Primary Key: Id/ID/id EntityName+Id
        public string Title { get; set; }   // NvarChar(MAX) - 2 Gb
        public int Pages { get; set; }
        public decimal Price { get; set; }
        public int AuthorId { get; set; }   // Foreign Key: RelateEntity+PrimaryKeyName

        // navigation properties - reference to an another column
        public Author Author { get; set; }
    }
    // ...
    // Relationship: One to Many (1...*)
    // ...
    class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }

        // navigation properties
        public ICollection<Book> Books { get; set; }
    }
}
