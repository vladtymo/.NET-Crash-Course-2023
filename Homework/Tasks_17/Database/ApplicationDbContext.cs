using Microsoft.EntityFrameworkCore;
using Tasks_17.Database.Configurations;
using Tasks_17.Database.Entities;

namespace Tasks_17.Database
{
	public class ApplicationDbContext : DbContext
	{
		public DbSet<AlbumEntity> Albums { get; set; }
		public DbSet<PlaylistEntity> Playlists { get; set; }
		public DbSet<SongEntity> Songs { get; set; }
		public DbSet<ArtistEntity> Artists { get; set; }

		public ApplicationDbContext()
		{
			Database.Migrate();
		}
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Data Source=localhost;Database=CrashCourseTasks17;Trusted_Connection=True;TrustServerCertificate=True;");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new AlbumConfiguration());
			modelBuilder.ApplyConfiguration(new SongConfiguration());
			modelBuilder.ApplyConfiguration(new PlaylistConfiguration());
			modelBuilder.ApplyConfiguration(new ArtistConfiguration());
		}


	}
}
