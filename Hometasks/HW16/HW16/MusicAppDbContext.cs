using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW16.Entities;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;

namespace HW16
{
    internal class MusicAppDbContext : DbContext
    {
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Playlist> Playlists { get; set; }

        public MusicAppDbContext()
        {
            this.Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            // connection string contains all neccessary info for connect to the db
            optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = Music_App; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Artist>().HasData(new[]
            {
                new Artist()
                {
                    Id = 1,
                    FirstName = "Nathan",
                    LastName = "Feuerstein",
                    Country = "USA"
                },
                new Artist()
                {
                    Id = 2,
                    FirstName = "Oleg",
                    LastName = "Psyuk",
                    Country = "Ukraine"
                },
                new Artist()
                {
                    Id = 3,
                    FirstName = "Mike",
                    LastName = "Shinoda",
                    Country = "USA"
                },
                new Artist()
                {
                    Id = 4,
                    FirstName = "Oleksandr",
                    LastName = "Yarmak",
                    Country = "Ukraine"
                },
                new Artist()
                {
                    Id = 5,
                    FirstName = "Montero",
                    LastName = "Hill",
                    Country = "USA"
                },
            });
            /*
            modelBuilder.Entity<Album>().HasData(new[]
            {
                new Album()
                {
                    Id = 1,
                    Name = "The Search",
                    ArtistId = 1,
                    Artist = Artists.Find(0)
                },
                new Album()
                {
                    Id = 2,
                    Name = "HOTIN",
                    ArtistId = 2,
                    Artist = Artists.Find(1)
                },
                new Album()
                {
                    Id = 3,
                    Name = "Meteora",
                    ArtistId = 3,
                    Artist = Artists.Find(2)
                },
                new Album()
                {
                    Id = 4,
                    Name = "Made in UA",
                    ArtistId = 4,
                    Artist = Artists.Find(3)
                },
                new Album()
                {
                    Id = 5,
                    Name = "Montero",
                    ArtistId = 5,
                    Artist = Artists.Find(4)
                },
            });
            */
        }
    }
}
