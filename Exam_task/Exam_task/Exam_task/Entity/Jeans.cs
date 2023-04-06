

namespace Exam_task.Entity
{
    internal class Jeans : Goods
    {
        public int Size { get; set; }

        public Jeans(string name, decimal price, int number, CategoryGoods category, int size) 
            : base(name, price, number, category)
        {
            Size = size;
        }
    }
}
