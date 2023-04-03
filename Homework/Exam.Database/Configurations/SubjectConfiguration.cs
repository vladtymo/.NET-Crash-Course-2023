using Exam_Task.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Exam_Task.Database.Configurations
{
	public class SubjectConfiguration : IEntityTypeConfiguration<SubjectEntity>
	{
		public void Configure(EntityTypeBuilder<SubjectEntity> builder)
		{
			builder
				.ToTable("Subjects")
				.HasKey(subj => subj.Id);
			builder
				.HasOne<StudentEntity>(subj=>subj.Student)
				.WithMany(stud=>stud.Subjects)
				.HasForeignKey(subj=>subj.StudentFK)
				.OnDelete(DeleteBehavior.Cascade);
		}
	}
}
