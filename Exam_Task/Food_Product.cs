namespace Exam_Task
{
    public class Food_Product   :   Goods
    {
        public string TypeProduct { get; }
        public Food_Product(string name, decimal price, int quantity,string typeProduct)
            :base(name,"Food", price,quantity)
        {
            TypeProduct = typeProduct;
        }
        public override void ShowInfo() {
            base.ShowInfo();
            Console.WriteLine($"Тип продукту: {this.TypeProduct}");
            Console.WriteLine();
        }

    }
}