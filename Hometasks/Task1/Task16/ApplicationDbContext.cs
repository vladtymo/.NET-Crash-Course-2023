using Microsoft.EntityFrameworkCore;
using Task16.Configurations;
using Task16.Entities;

namespace Task16
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<AlbumEntity> Albums { get; set; }
        public DbSet<ArtistEntity> Artists { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<CountyEntity> Counties { get; set; }
        public DbSet<GenreEntity> Genres { get; set; }
        public DbSet<PlaylistEntity> Playlists { get; set; }
        public DbSet<TrackEntity> Tracks { get; set; }

        public ApplicationDbContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Database=Task16Db;Trusted_Connection=True;Encrypt=false");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AlbumConfiguration());
            modelBuilder.ApplyConfiguration(new ArtistConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new CountryConfiguration());
            modelBuilder.ApplyConfiguration(new GenreConfiguration());
            modelBuilder.ApplyConfiguration(new PlaylistConfiguration());
            modelBuilder.ApplyConfiguration(new PlaylistTracksConfiguration());
            modelBuilder.ApplyConfiguration(new TrackConfiguration());
        }
    }
}