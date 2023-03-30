using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
            //this.Database.EnsureCreated();
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
            modelBuilder.Entity<Country>().HasData(new[]
            {
                new Country() { Id = 1, Name = "Ukraine" },
                new Country() { Id = 2, Name = "France" },
                new Country() { Id = 3, Name = "USA" },
                new Country() { Id = 4, Name = "Italy" },
                new Country() { Id = 5, Name = "United Kindom" },
            });

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

            // Fluent API
            modelBuilder.Entity<Country>().HasKey(x => x.Id);
            modelBuilder.Entity<Country>().ToTable("CountryTable");
            modelBuilder.Entity<Country>().Property(x => x.Name)
                                                .HasMaxLength(150)
                                                .IsRequired();

            // configure relationships
            modelBuilder.Entity<Country>().HasMany(x => x.Authors)
                                           .WithOne(x => x.Country)
                                           .HasForeignKey(x => x.CountryId);
        }

        // ---------- data collections (tables) ----------
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Country> Countries { get; set; }
    }

    // ---------- entities ----------
    class Book
    {
        // properties (columns)
        [Key]                               // Set Primary Key
        public int Id { get; set; }         // Primary Key: Id/ID/id EntityName+Id
        [Required]
        [MaxLength(200)]                    // NvarChar(200)
        public string Title { get; set; }   
        public int Pages { get; set; }
        public decimal Price { get; set; }
        public float Rating { get; set; }
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
        public int CountryId { get; set; }

        // navigation properties
        public Country Country { get; set; }
        public ICollection<Book> Books { get; set; }
    }

    class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // navigation properties
        public ICollection<Author> Authors { get; set; }
    }
}
