
namespace lesson_11_HW
{
    public class Shape
    {
        public string type;
        public struct coordinate
        {
            public int x; 
            public int y;
        }
        public ConsoleColor Color { get; init; }
        public virtual void Print() { }
    }
}
