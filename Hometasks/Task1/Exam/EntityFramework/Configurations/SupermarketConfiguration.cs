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

            builder.HasMany<GoodsEntity>(sumermarket => sumermarket.Goods)
                .WithOne(goods => goods.Supermarket)
                .HasForeignKey(goods => goods.SupermarketFK)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany<ProductEntity>(supermarket => supermarket.Products)
                .WithOne(products => products.Supermarket)
                .HasForeignKey(product => product.SupermarketFK)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}