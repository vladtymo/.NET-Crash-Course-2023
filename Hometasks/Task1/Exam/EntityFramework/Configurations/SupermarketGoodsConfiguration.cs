using Exam.Database.Enitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Exam.EntityFramework.Configurations
{
    public class SupermarketGoodsConfiguration : IEntityTypeConfiguration<SupermarketGoodsEntity>
    {
        public void Configure(EntityTypeBuilder<SupermarketGoodsEntity> builder)
        {
            builder.ToTable("SupermarketGoods").HasKey(sg => new { sg.SupermarketFK, sg.GoodsFK });

            builder.HasOne<SupermarketEntity>(sg => sg.Supermarket)
                .WithMany(supermarket => supermarket.SupermarketGoods)
                .HasForeignKey(sg => sg.SupermarketFK);

            builder.HasOne<GoodsEntity>(sg => sg.Goods)
                .WithMany(goods => goods.SupermarketGoods)
                .HasForeignKey(sg => sg.GoodsFK);
        }
    }
}