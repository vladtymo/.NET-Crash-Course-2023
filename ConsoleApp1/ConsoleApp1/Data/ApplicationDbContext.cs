using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Data
{
    internal class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
            this.Database.EnsureCreated();
        }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Playlist> Playlists { get; set; }
    }

    class Artist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Country { get; set; }

    }

    class Album
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ArtistId { get; set; }
        public DateOnly Year { get; set; }
        public string Genre { get; set; }


    }

    class Track
    {
        public string Name { get; set; }
        public int DuartionSec { get; set; }
        public Album Album { get; set; }

    }

    class Playlist
    {
        public string Name { get; set; }
        public ICollection<Track> Tracks { get; set; }
        public string Category { get; set; }
    }
}
