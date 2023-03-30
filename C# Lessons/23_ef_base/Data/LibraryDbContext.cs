using _23_ef_base.Entities;
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
            //this.Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            // TODO: move conn str to a app settigns/configuration file
            // connection string contains all neccessary info for connect to the db
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Library_DB_Crash;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // data initialization
            DbInitializer.SeedCountries(modelBuilder);
            DbInitializer.SeedAuthors(modelBuilder);

            // TODO: move to a separate class
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
}
