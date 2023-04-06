namespace Exam_Task
{
    public class Textile : Goods
    {
        public string TypeProduct { get; }
        public Textile(string name, decimal price, int quantity, string typeProduct)
            : base(name, "Textile", price, quantity)
        {
            TypeProduct = typeProduct;

        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Тип продукту: {this.TypeProduct}");
            Console.WriteLine();
        }

    }
}