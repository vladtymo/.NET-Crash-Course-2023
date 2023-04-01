using Exam.Database.Enitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Exam.EntityFramework.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<ProductEntity>
    {
        public void Configure(EntityTypeBuilder<ProductEntity> builder)
        {
            builder.ToTable("Products").HasKey(product => product.Id);

            builder.Property(product => product.Name).HasMaxLength(63).IsRequired();
            builder.Property(product => product.Description).HasMaxLength(255).IsRequired(false);
        }
    }
}