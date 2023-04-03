using Exam_Task.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Exam_Task.Database.Configurations
{
	public class GroupConfiguration : IEntityTypeConfiguration<GroupEntity>
	{
		public void Configure(EntityTypeBuilder<GroupEntity> builder)
		{
			builder
				.ToTable("Groups")
				.HasKey(group => group.Id);
		}
	}
}
