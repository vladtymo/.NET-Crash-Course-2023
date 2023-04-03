using Exam_Task.Database.Configurations;
using Exam_Task.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace Exam_Task.Database
{
	public class ApplicationDbContext : DbContext
	{
		public DbSet<LecturerEntity> Lecturers { get; set;}
		public DbSet<SubjectEntity> Subjects { get; set;}
		public DbSet<StudentEntity> Students { get; set;}
		public DbSet<GroupEntity> Groups { get; set;}
		public ApplicationDbContext()
		{
			Database.Migrate();
		}
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Data Source=localhost;Database=ExamTask;Trusted_Connection=True;TrustServerCertificate=True;");
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new LecturerConfiguration());
			modelBuilder.ApplyConfiguration(new SubjectConfiguration());
			modelBuilder.ApplyConfiguration(new StudentConfiguration());
			modelBuilder.ApplyConfiguration(new GroupConfiguration());
		}
	}
}
