using Exam_Task.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Exam_Task.Database.Configurations
{
	public class LecturerConfiguration : IEntityTypeConfiguration<LecturerEntity>
	{
		public void Configure(EntityTypeBuilder<LecturerEntity> builder)
		{
			builder
				.ToTable("Lecturers")
				.HasKey(l => l.Id);
			builder
				.HasOne<SubjectEntity>(lect => lect.Subject)
				.WithOne(subj => subj.Lecturer)
				.HasForeignKey<LecturerEntity>(lect => lect.SubjectFK)
				.OnDelete(DeleteBehavior.Cascade);
		}
	}
}
