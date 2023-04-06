

using static Snake.Program;

namespace Snake
{
    class Field
    {
        public void Draw()
        {
            for (int i = 0; i < heigth; i++)
            {
                new Pixel(0, i, '0', ConsoleColor.Blue);
                new Pixel(width - 1, i, '0', ConsoleColor.Blue);
            }

            for (int i = 0; i < width; i++)
            {
                new Pixel(i, 0, '0', ConsoleColor.Blue);
                new Pixel(i, heigth - 1, '0', ConsoleColor.Blue);
            }
        }

        public Pixel FormationtFood(Snake snake)
        {
             Random random = new Random();

            Pixel eat;
            do
            {
                eat = new Pixel(random.Next(1, width - 2), random.Next(1, heigth - 2), '#', ConsoleColor.Green);

            }
            while (snake.Head.X == eat.X && snake.Head.Y == eat.Y || snake.Body.Any(b => b.X == eat.X && b.Y == eat.Y));

            return eat;
        }

    }
}
