using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_16.Data
{
    internal class LibraryDbContext : DbContext
    {
        public LibraryDbContext()
        {
            this.Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog = Me1nychuk;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        public DbSet<Album> Albums { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Playlist> Playlists { get; set; }
    }

    class Artist
    {
        public int ArtistId { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string Country { get; set; }
        public ICollection<Track> Track { get; set; }
        public ICollection<Album> Albums { get; set; }


    }

    class Track
    {
        public int TrackId { get; set; }
        public int Name { get; set; }
        public double Duration { get; set; }
        public int ArtistId { get; set; }
        public Artist Artist { get; set; }


    }

    class Album
    {
        public int AlbumId { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public int ArtistId { get; set; }
        public ICollection<Track> Track { get; set; }

    }

    class Playlist
    {
        public int PlaylistId { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public ICollection<Track> Track { get; set; }
    }
}



