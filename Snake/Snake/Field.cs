

using Snake.Interface;
using static Snake.Program;

namespace Snake
{
    class Field : IDraw
    {
        public void Clear()
        {
            Console.Clear();
        }

        public void Draw()
        {
            for (int i = 0; i < heigth; i++)
            {
                new Element(0, i, '0', ConsoleColor.Blue);
                new Element(width - 1, i, '0', ConsoleColor.Blue);
            }

            for (int i = 0; i < width; i++)
            {
                new Element(i, 0, '0', ConsoleColor.Blue);
                new Element(i, heigth - 1, '0', ConsoleColor.Blue);
            }
        }

        public Element FormationtFood(Snake snake)
        {
             Random random = new Random();

            Element eat;
            do
            {
                eat = new Element(random.Next(1, width - 2), random.Next(1, heigth - 2), '#', ConsoleColor.Green);

            }
            while (snake.Head.X == eat.X && snake.Head.Y == eat.Y || snake.Body.Any(b => b.X == eat.X && b.Y == eat.Y));

            return eat;
        }


    }
}
