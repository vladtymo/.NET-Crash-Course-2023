using Exam.Database.Enums;

namespace Exam.Database.Enitites
{
    public class ProductEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime ExpirationDate { get; set; }
        public ProductCategory Category { get; set; }
        public float Price { get; set; }
        public int Count { get; set; }

        public ICollection<SupermarketProductsEntity> SupermarketProducts { get; set; }
    }
}