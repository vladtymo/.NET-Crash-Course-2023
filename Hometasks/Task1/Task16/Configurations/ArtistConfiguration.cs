using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Task16.Entities;

namespace Task16.Configurations
{
    public class ArtistConfiguration : IEntityTypeConfiguration<ArtistEntity>
    {
        public void Configure(EntityTypeBuilder<ArtistEntity> builder)
        {
            builder.ToTable("Artists").HasKey(artist => artist.Id);

            builder.HasOne<CountyEntity>()
                .WithMany(country => country.Artists)
                .HasForeignKey(artist => artist.CountryFK)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}