using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace MusicApp{
    public class Artist{
        public int ArtistId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public ICollection<Album> Albums { get; set; }
    }
    public class Country{
        public int CountryId { get; set; }
        public string Name { get; set; }
        public ICollection<Artist> Artists { get; set; }
    }
    public class Album{
        public int AlbumId { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }
        public int ArtistId { get; set; }
        public Artist Artist { get; set; }
        public ICollection<Track> Tracks { get; set; }
    }
    public class Track{
        public int TrackId { get; set; }
        public string Name { get; set; }
        public TimeSpan Duration { get; set; }
        public int AlbumId { get; set; }
        public Album Album { get; set; }
        public ICollection<PlaylistTrack> PlaylistTracks { get; set; }
    }
    public class Playlist{
        public int PlaylistId { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<PlaylistTrack> PlaylistTracks { get; set; }
    }
    public class Category{
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public ICollection<Playlist> Playlists { get; set; }
    }
    public class PlaylistTrack{
        public int PlaylistId { get; set; }
        public Playlist Playlist { get; set; }
        public int TrackId { get; set; }
        public Track Track { get; set; }
    }
    public class MusicContext : DbContext{
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Track> Tracks { get; set; }
        public DbSet<Playlist> Playlists { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<PlaylistTrack> PlaylistTracks { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseSqlServer("Server=localhost;Database=MusicAppDb;User Id=sa;Password=Anton233@;Encrypt=False;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<PlaylistTrack>().HasKey(pt => new { pt.PlaylistId, pt.TrackId });
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new MusicContext())
            {
                context.Database.Migrate();
                Seed(context);
                var playlist = new Playlist { Name = "new playlist", Category = context.Categories.SingleOrDefault(c => c.Name == "new singls") };
                if (playlist.Category != null)
                {
                    context.Playlists.Add(playlist);
                    var tracks = context.Tracks.ToList();
                    foreach (var track in tracks)
                    {
                        context.PlaylistTracks.Add(new PlaylistTrack { Playlist = playlist, Track = track });
                    }
                    context.SaveChanges();
                    Console.WriteLine($"Playlist: {playlist.Name} ({playlist.Category.Name})");
                    foreach (var track in playlist.PlaylistTracks.Select(pt => pt.Track))
                    {
                        Console.WriteLine($"- {track.Name} ({track.Duration})");
                    }
                }
                else
                {
                    Console.WriteLine("Category 'new singls' not found.");
                }
            }
        }
        private static void Seed(MusicContext context)
        {
            if (!context.Categories.Any(c => c.Name == "new singls"))
            {
                context.Categories.Add(new Category { Name = "new singls" });
                context.SaveChanges();
            }
            if (!context.Countries.Any())
            {
                var country = new Country { Name = "Ukraine" };
                context.Countries.Add(country);
                var artist = new Artist { FirstName = "Karina", LastName = "Zubko", Country = country };
                context.Artists.Add(artist);
                var album = new Album { Name = "my album", Year = 2023, Genre = "Rock", Artist = artist };
                context.Albums.Add(album);
                var track1 = new Track { Name = "track 1", Duration = TimeSpan.FromSeconds(50), Album = album };
                var track2 = new Track { Name = "track 2", Duration = TimeSpan.FromSeconds(50), Album = album };
                context.Tracks.AddRange(track1, track2);
                context.SaveChanges();
            }
        }

    }
}