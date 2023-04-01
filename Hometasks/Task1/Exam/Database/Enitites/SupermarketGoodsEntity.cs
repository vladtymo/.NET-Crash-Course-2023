namespace Exam.Database.Enitites
{
    public class SupermarketGoodsEntity
    {
        public long SupermarketFK { get; set; }
        public SupermarketEntity Supermarket { get; set; }

        public long GoodsFK { get; set; }
        public GoodsEntity Goods { get; set; }
    }
}