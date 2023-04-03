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
        
        public DateTime CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public DateTime? DeletedOn { get; set; }

        public long CheckFK { get; set; }
        public CheckEntity Check { get; set; }

        public long SupermarketFK { get; set; }
        public SupermarketEntity Supermarket { get; set; }
    }
}