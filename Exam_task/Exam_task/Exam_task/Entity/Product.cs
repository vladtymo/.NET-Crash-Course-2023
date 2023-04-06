
namespace Exam_task
{
    internal  class Product : IComparable<Product>
    {
        public enum CategoryProduct {Milky = 1, Bakery, Fish, Meat, Fruits, Vegetables, Other }
        private readonly DateTime expirationDate;
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Number { get; set; }
        public CategoryProduct Category { get; set; }

        public Product(string name, DateTime expirationDate, decimal price, int number, CategoryProduct category)
        {
            Name = name;
            this.expirationDate = expirationDate < DateTime.Now ?  DateTime.Now : expirationDate;
            Price = price < 0 ? 100 : price;
            Number = number < 0 ? 10 : number;
            Category = category;
        }

        public override string ToString() => $"Name: {Name}\n" +
                                        $"Expiration date: {expirationDate}\n" +
                                        $"Price: {Price}\n" +
                                        $"Number: {Number}\n" + 
                                        $"Category product: {Category}\n";

        public int CompareTo(Product? other)
        {
            if (other == null) return 1;
            return this.Category.CompareTo(other.Category) * -1;
        }
    }
}
