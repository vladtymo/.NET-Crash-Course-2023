using Exam.Database.Enums;

namespace Exam.Database.Enitites
{
    public class GoodsEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public GoodsCategory Category { get; set; }
        public float Price { get; set; }
        public int Count { get; set; }

        public ICollection<SupermarketGoodsEntity> SupermarketGoods { get; set; }
    }
}