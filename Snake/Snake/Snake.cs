
using Snake.Interface;
using static Snake.Program;

namespace Snake
{
    class Snake : IDraw
    {
        public enum Direction { Left, Right, Up, Down }
        //public delegate Direction Directions(Snake snake);
        //public event Direction CheckMove;

        private int curX;
        private int curY;
        public Pixel Head { get; set; }
        public Queue<Pixel> Body { get; set; }
        public Direction EnumDirectiont { get; set; }
        public Snake(int startX, int startY)
        {
            int number = 3;
            EnumDirectiont = Direction.Right;
            curX = startX;
            curY = startY;
            Body = new Queue<Pixel>();
            Head = new Pixel(startX, startY, '0', ConsoleColor.Red);
            for (int i = number; i > 0; i--)
            {
                Body.Enqueue(new Pixel(Head.X - i - 1, startY, '*', ConsoleColor.Cyan));
            }
        }

        public void Draw()
        {
            Head.Draw();
            foreach (Pixel px in Body)
            {
                px.Draw();
            }
        }

        public void Clear()
        {

            Head.Clear();
            foreach (Pixel px in Body)
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
            //Direction direction = MoveEvent.
            Clear();
            Body.Enqueue(new Pixel(Head.X, Head.Y, '*', ConsoleColor.Cyan));
            if (!eat)
                Body.Dequeue();

            Head = direction switch
            {
                Direction.Up => new Pixel(Head.X, Head.Y - 1, '0', ConsoleColor.Red),
                Direction.Down => new Pixel(Head.X, Head.Y + 1, '0', ConsoleColor.Red),
                Direction.Left => new Pixel(Head.X - 1, Head.Y, '0', ConsoleColor.Red),
                Direction.Right => new Pixel(Head.X + 1, Head.Y, '0', ConsoleColor.Red),
                _ => Head
            };
            Draw();

        }
    }
}
