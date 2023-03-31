using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Task16.Entities;

namespace Task16.Configurations
{
    public class PlaylistConfiguration : IEntityTypeConfiguration<PlaylistEntity>
    {
        public void Configure(EntityTypeBuilder<PlaylistEntity> builder)
        {
            builder.ToTable("Playlists").HasKey(playlist => playlist.Id);

            builder.HasOne<CategoryEntity>(playlist => playlist.Category)
                .WithMany(category => category.Playlists)
                .HasForeignKey(playlist => playlist.CategoryFK);
        }
    }
}