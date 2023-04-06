namespace Exam_Task
{
    public class Goods 
    {
        public string Name { get;}
        public string Category { get; }
        public decimal Price { get; }
        public int Quantity { get; set; }
        public Goods(string name, string category, decimal price, int quantity)
        {
            Name = name;
            Category = category;
            Price = price;
            Quantity = quantity;
            
        }
        public virtual void ShowInfo() {
            Console.WriteLine($"Назва: {this.Name}");
            Console.WriteLine($"Категорiя: {this.Category}");
            Console.WriteLine($"Кiлькiсть: {this.Quantity}");
            Console.WriteLine($"Цiна: {this.Price}");
        }
    }
}