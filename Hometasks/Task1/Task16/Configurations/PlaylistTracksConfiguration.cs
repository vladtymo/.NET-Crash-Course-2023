using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Task16.Entities;

namespace Task16.Configurations
{
    public class PlaylistTracksConfiguration : IEntityTypeConfiguration<PlaylistTracksEntity>
    {
        public void Configure(EntityTypeBuilder<PlaylistTracksEntity> builder)
        {
            builder.ToTable("Playlist tracks").HasKey(pt => new { pt.PlaylistFK, pt.TrackFK });

            builder.HasOne<PlaylistEntity>(pt => pt.Playlists)
                .WithMany(playlist => playlist.PlaylistTracks)
                .HasForeignKey(pt => pt.PlaylistFK);

            builder.HasOne<TrackEntity>(pt => pt.Tracks)
                .WithMany(track => track.PlaylistTracks)
                .HasForeignKey(pt => pt.TrackFK);
        }
    }
}