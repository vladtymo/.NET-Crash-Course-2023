namespace Exam.Database.Enitites
{
    public class SupermarketEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public ICollection<SupermarketProductsEntity> SupermarketProducts { get; set; }
        public ICollection<SupermarketGoodsEntity> SupermarketGoods { get; set; }
    }
}