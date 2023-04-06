

namespace Exam_task
{
    internal class Goods : IComparable<Goods>
    {
        public enum CategoryGoods{ Chemicals = 1, Textile, Pyrotechnics, SpecialMeans, Other }
        public  string Name { get; set; }
        public decimal Price { get; set; }
        public int Number { get; set; }
        public CategoryGoods Category { get; set; }

        public Goods(string name, decimal price, int number, CategoryGoods category)
        {
            Name = name;
            Price = price < 0 ? 100 : price;
            Number = number < 0 ? 10 : number;
            Category = category;
        }

        public override string ToString() => $"Name: {Name}\n" +
                                $"Price: {Price}\n" +
                                $"Number: {Number}\n" +
                                $"Category goods: {Category}\n";

        public int CompareTo(Goods? other)
        {
            if (other == null) return 1;
            return this.Category.CompareTo(other.Category) * -1;
        }
    }
}
