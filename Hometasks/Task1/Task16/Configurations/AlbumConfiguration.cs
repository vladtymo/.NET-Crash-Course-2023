using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Task16.Entities;

namespace Task16.Configurations
{
    public class AlbumConfiguration : IEntityTypeConfiguration<AlbumEntity>
    {
        public void Configure(EntityTypeBuilder<AlbumEntity> builder)
        {
            builder.ToTable("Albums").HasKey(album => album.Id);

            builder.HasOne<ArtistEntity>()
                .WithMany(artist => artist.Albums)
                .HasForeignKey(album => album.ArtistFK)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne<GenreEntity>(album => album.Genre)
                .WithMany(genre => genre.Albums)
                .HasForeignKey(album => album.GenreFK);
        }
    }
}