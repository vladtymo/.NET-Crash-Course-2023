
using static Snake.Program;
using Snake.Interface;

namespace Snake
{
    public struct Element : IDraw
    {
        public int X { get; set; }
        public int Y { get; set; }
        public char Char { get; set; }
        public ConsoleColor Color { get; set; }
        public Element(int x, int y, char ch, ConsoleColor color)
        {

            Color = color;
            X = x;
            Y = y;
            Char = ch;

            Draw();
        }

        public void Draw()
        {
            Console.ForegroundColor = Color;
            Console.SetCursorPosition(X, Y);
            Console.Write(Char);
        }

        public void Clear()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(' ');
        }
    }

}
