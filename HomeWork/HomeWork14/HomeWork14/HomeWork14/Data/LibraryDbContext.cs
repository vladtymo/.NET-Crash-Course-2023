using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork14.Data
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
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=master;Trusted_Connection=True;");
        }

        // ---------- data collections (tables) ----------
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Track> Tracks { get; set; }
        public DbSet<Playlist> Playlists { get; set; }
    }

    // ---------- entities ----------
    public class Artist
    {
        public int ArtistId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public ICollection<Album> Albums { get; set; }
    }
    // ...
    // Relationship: One to Many (1...*)
    // ...
    public class Album
    {
        public int AlbumId { get; set; }
        public string Name { get; set; }
        public int ArtistId { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }

        public Artist Artist { get; set; }
        public ICollection<Track> Tracks { get; set; }
    }
    public class Track
    {
        public int TrackId { get; set; }
        public string Name { get; set; }
        public int AlbumId { get; set; }
        public TimeSpan Duration { get; set; }

        public Album Album { get; set; }
        public ICollection<Playlist> Playlists { get; set; }
    }

    public class Playlist
    {
        public int PlaylistId { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }

        public ICollection<Track> Tracks { get; set; }
    }



}
