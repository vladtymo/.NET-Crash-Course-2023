using Exam.Database.Enitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Exam.EntityFramework.Configurations
{
    public class GoodsConfigurations : IEntityTypeConfiguration<GoodsEntity>
    {
        public void Configure(EntityTypeBuilder<GoodsEntity> builder)
        {
            builder.ToTable("Goods").HasKey(goods => goods.Id);

            builder.Property(goods => goods.Name).HasMaxLength(63).IsRequired();
        }
    }
}