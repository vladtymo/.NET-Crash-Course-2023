using Exam.Database.Enitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Exam.EntityFramework.Configurations
{
    public class CheckConfiguration : IEntityTypeConfiguration<CheckEntity>
    {
        public void Configure(EntityTypeBuilder<CheckEntity> builder)
        {
            builder.ToTable("Checks").HasKey(check => check.Id);

            builder.HasMany<GoodsEntity>(check => check.Goods)
                .WithOne(goods => goods.Check)
                .HasForeignKey(goods => goods.CheckFK);

            builder.HasMany<ProductEntity>(check => check.Products)
                .WithOne(product => product.Check)
                .HasForeignKey(product => product.CheckFK);
        }
    }
}