using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tasks_17.Database.Entities;

namespace Tasks_17.Database.Configurations
{
	internal class SongConfiguration : IEntityTypeConfiguration<SongEntity>
	{
		public void Configure(EntityTypeBuilder<SongEntity> builder)
		{
			throw new NotImplementedException();
		}
	}
}
