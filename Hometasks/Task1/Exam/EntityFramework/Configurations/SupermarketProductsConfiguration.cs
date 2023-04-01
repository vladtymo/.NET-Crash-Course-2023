using Exam.Database.Enitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Exam.EntityFramework.Configurations
{
    public class SupermarketProductsConfiguration : IEntityTypeConfiguration<SupermarketProductsEntity>
    {
        public void Configure(EntityTypeBuilder<SupermarketProductsEntity> builder)
        {
            builder.ToTable("SupermarketProducts").HasKey(sp => new { sp.ProductFK, sp.SupermarketFK });

            builder.HasOne<SupermarketEntity>(sp => sp.Supermarket)
                .WithMany(supermarket => supermarket.SupermarketProducts)
                .HasForeignKey(sp => sp.SupermarketFK);

            builder.HasOne<ProductEntity>(sp => sp.Product)
                .WithMany(product => product.SupermarketProducts)
                .HasForeignKey(sp => sp.ProductFK);
        }
    }
}