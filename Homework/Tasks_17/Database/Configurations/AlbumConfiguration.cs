using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tasks_17.Database.Entities;

namespace Tasks_17.Database.Configurations
{
	public class AlbumConfiguration : IEntityTypeConfiguration<AlbumEntity>
	{
		void IEntityTypeConfiguration<AlbumEntity>.Configure(EntityTypeBuilder<AlbumEntity> builder)
		{
			throw new NotImplementedException();
		}
	}
}
