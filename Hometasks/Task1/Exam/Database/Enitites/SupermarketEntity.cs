namespace Exam.Database.Enitites
{
    public class SupermarketEntity
    {
        public SupermarketEntity()
        {
            Goods = new List<GoodsEntity>();
            Products = new List<ProductEntity>();
            Checks = new List<CheckEntity>();
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public DateTime? DeletedOn { get; set; }

        public ICollection<GoodsEntity> Goods { get; set; }
        public ICollection<ProductEntity> Products { get; set; }
        public ICollection<CheckEntity> Checks { get; set; }
    }
}