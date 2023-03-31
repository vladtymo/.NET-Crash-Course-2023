using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Task16.Entities;

namespace Task16.Configurations
{
    public class TrackConfiguration : IEntityTypeConfiguration<TrackEntity>
    {
        public void Configure(EntityTypeBuilder<TrackEntity> builder)
        {
            builder.ToTable("Tracks").HasKey(track => track.Id);

            builder.HasOne<AlbumEntity>(track => track.Album)
                .WithMany(album => album.Tracks)
                .HasForeignKey(track => track.AlbumFK);
        }
    }
}