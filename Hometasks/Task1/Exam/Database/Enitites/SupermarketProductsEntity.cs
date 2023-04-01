namespace Exam.Database.Enitites
{
    public class SupermarketProductsEntity
    {
        public long SupermarketFK { get; set; }
        public SupermarketEntity Supermarket { get; set; }

        public long ProductFK { get; set; }
        public ProductEntity Product { get; set; }
    }
}