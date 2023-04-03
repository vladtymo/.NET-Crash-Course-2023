using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tasks_17.Database.Entities;

namespace Tasks_17.Database.Configurations
{
	public class ArtistConfiguration : IEntityTypeConfiguration<ArtistEntity>
	{
		public void Configure(EntityTypeBuilder<ArtistEntity> builder)
		{
			throw new NotImplementedException();
		}
	}
}
