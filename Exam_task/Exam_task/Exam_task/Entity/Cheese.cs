

namespace Exam_task.Entity
{
    internal class Cheese : Product
    {
        public enum KindCheese {King = 1, Brynza, Edam, Emmental }
        public int Mass { get; set; }
        public KindCheese Kind { get; set; }
        public Cheese(string name, DateTime expirationDate, decimal price, int number, CategoryProduct category, KindCheese kind, int mass) 
            : base(name, expirationDate, price, number, category)
        {
            Kind = kind;
            Mass = mass > 0 ? mass : 100;
        }

        public override string ToString()
        {
            base.ToString();
            return $"Mass: {Mass}\n Kind: {Kind}";
        }
    }
}
