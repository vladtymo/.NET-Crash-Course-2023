using Exam_Task.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Exam_Task.Database.Configurations
{
	public class StudentConfiguration : IEntityTypeConfiguration<StudentEntity>
	{
		public void Configure(EntityTypeBuilder<StudentEntity> builder)
		{
			builder
				.ToTable("Students")
				.HasKey(stud => stud.Id);
			builder
				.HasOne<GroupEntity>(st => st.Group)
				.WithMany(group => group.Students)
				.HasForeignKey(st=>st.GroupFK)
				.OnDelete(DeleteBehavior.Cascade);
		}
	}
}
