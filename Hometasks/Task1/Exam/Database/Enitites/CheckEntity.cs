namespace Exam.Database.Enitites
{
    public class CheckEntity
    {
        public long Id { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public DateTime? DeletedOn { get; set; }
        
        public long SupermarketFK { get; set; }
        public SupermarketEntity Supermarket { get; set; }

        public ICollection<GoodsEntity> Goods { get; set; }
        public ICollection<ProductEntity> Products { get; set; }
    }
}