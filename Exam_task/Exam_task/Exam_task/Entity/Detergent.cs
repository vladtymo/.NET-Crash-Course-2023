
namespace Exam_task.Entity
{
    internal class Detergent : Goods
    {
        public int Capacity { get; set; }

        public Detergent(string name, decimal price, int number, CategoryGoods category, int capacity) 
            : base(name, price, number, category)
        {
            Capacity = capacity;
        }

        public override string ToString()
        {
            base.ToString();
            return $"Capacity: {Capacity}";
        }
    }
}
