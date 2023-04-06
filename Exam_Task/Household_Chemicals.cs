namespace Exam_Task
{
    public class Household_Chemicals : Goods
    {
        public string TypeProduct { get; }
        public Household_Chemicals(string name, decimal price, int quantity, string typeProduct)
            : base(name, "Household_Chemicals", price, quantity)
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