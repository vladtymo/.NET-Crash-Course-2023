
using Snake.Interface;
using static Snake.Program;

namespace Snake
{
    class Snake : IDraw
    {
        public enum Direction { Left, Right, Up, Down }

        private int curX;
        private int curY;
        public Element Head { get; set; }
        public Queue<Element> Body { get; set; }
        public Direction EnumDirectiont { get; set; }
        public Snake()
        {
            int number = 3;
            EnumDirectiont = Direction.Right;
            curX = width / 2 - 5;
            curY = heigth / 2; ;
            Body = new Queue<Element>();
            Head = new Element(curX, curY, '0', ConsoleColor.Red);
            for (int i = number; i > 0; i--)
            {
                Body.Enqueue(new Element(Head.X - i - 1, curY, '*', ConsoleColor.Cyan));
            }
        }

        public void Draw()
        {
            Head.Draw();
            foreach (Element px in Body)
            {
                px.Draw();
            }
        }

        public void Clear()
        {

            Head.Clear();
            foreach (Element px in Body)
            {
                px.Clear();
            }
        }

        public bool IsTouch()
        {
            if (Head.X == width - 1 || Head.X == 0 || Head.Y == heigth - 1 || Head.Y == 0 || Body.Any(b => b.X == Head.X && b.Y == Head.Y))
                return true;

            return false;
        }
        public Direction Check(Direction direction)
        {
            if (!Console.KeyAvailable)
                return direction;

            var key = Console.ReadKey().Key;
            direction = key switch
            {

                ConsoleKey.UpArrow when (direction != Direction.Down && direction != Direction.Up) => Direction.Up,
                ConsoleKey.DownArrow when (direction != Direction.Up && direction != Direction.Down) => Direction.Down,
                ConsoleKey.LeftArrow when (direction != Direction.Right && direction != Direction.Left) => Direction.Left,
                ConsoleKey.RightArrow when (direction != Direction.Left && direction != Direction.Right) => Direction.Right,
                _ => direction
            };
            EnumDirectiont = direction;
            return direction;
        }

        public void Move(Direction direction, bool eat)
        {
            Clear();
            Body.Enqueue(new Element(Head.X, Head.Y, '*', ConsoleColor.Cyan));
            if (!eat)
                Body.Dequeue();

            Head = direction switch
            {
                Direction.Up => new Element(Head.X, Head.Y - 1, '0', ConsoleColor.Red),
                Direction.Down => new Element(Head.X, Head.Y + 1, '0', ConsoleColor.Red),
                Direction.Left => new Element(Head.X - 1, Head.Y, '0', ConsoleColor.Red),
                Direction.Right => new Element(Head.X + 1, Head.Y, '0', ConsoleColor.Red),
                _ => Head
            };
            Draw();

        }
    }
}
