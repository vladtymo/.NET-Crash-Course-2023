using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tasks_17.Database.Entities;

namespace Tasks_17.Database.Configurations
{
	internal class PlaylistConfiguration : IEntityTypeConfiguration<PlaylistEntity>
	{
		public void Configure(EntityTypeBuilder<PlaylistEntity> builder)
		{
			throw new NotImplementedException();
		}
	}
}
