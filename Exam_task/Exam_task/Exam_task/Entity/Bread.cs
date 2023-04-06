

namespace Exam_task.Entity
{
    internal class Bread : Product
    {
        public enum KindBread { White = 1, Brown, Gray, Rye, Roll }
        public int Mass { get; set; }
        public KindBread Kind { get; private set; }
        public Bread(string name, DateTime expirationDate, decimal price, int number, CategoryProduct category, KindBread kind, int mass) 
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
