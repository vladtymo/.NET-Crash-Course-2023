using Exam.Database.Enitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Exam.EntityFramework.Configurations
{
    public class SupermarketConfiguration : IEntityTypeConfiguration<SupermarketEntity>
    {
        public void Configure(EntityTypeBuilder<SupermarketEntity> builder)
        {
            builder.ToTable("Supermarkets").HasKey(supermarket => supermarket.Id);

            builder.Property(supermarket => supermarket.Name).HasMaxLength(63).IsRequired();
        }
    }
}