using Snake.Interface;
using System.Numerics;
using System.Text.Json;

namespace Snake
{
    internal class Program
    {
        public const int width = 70, heigth = 40;
        public struct Pixel : IDraw
        {
            public int X { get; set; }
            public int Y { get; set; }
            public char Char { get; set; }
            public ConsoleColor Color { get; set; }
            public Pixel(int x, int y, char ch, ConsoleColor color)
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

        static void StartGame()
        {


        }
        static void Main(string[] args)
        {

            //List<Player> list = new List<Player>();

            Console.CursorVisible = false;
            Snake snake = new Snake(width / 2, heigth / 2);

            Text text = new Text();
            text.Draw();
            Field field = new Field();
            Pixel food = field.FormationtFood(snake);
            field.Draw();

            while (!snake.IsTouch() && !text.Win())
            {
                //Thread.Sleep(200);
                if (snake.Head.X == food.X && snake.Head.Y == food.Y)
                {
                    snake.Move(snake.Check(snake.EnumDirectiont), true);
                    food = field.FormationtFood(snake);
                    text.Draw();
                }
                else
                    snake.Move(snake.Check(snake.EnumDirectiont), false);
                field.Draw();
                Thread.Sleep(60);
            }

            text.EndGame();
            Console.SetCursorPosition(width, heigth);



           // string jsonToSave = JsonSerializer.Serialize();
        }
    }
}







/*public void Up()
{
    Clear();
    Body.Enqueue(new Pixel(Head.X, Head.Y, '*', ConsoleColor.Cyan));
    Body.Dequeue();
    Head = new Pixel(Head.X, Head.Y - 1, '0', ConsoleColor.Red);
    Draw();
    //UpEvent.Invoke();
}
public void Down()
{
    Clear();
    Body.Enqueue(new Pixel(Head.X, Head.Y, '*', ConsoleColor.Cyan));
    Body.Dequeue();
    Head = new Pixel(Head.X, Head.Y + 1, '0', ConsoleColor.Red);
    Draw();
    //DownEvent.Invoke();
}
public void Right()
{
    Clear();
    Body.Enqueue(new Pixel(Head.X, Head.Y, '*', ConsoleColor.Cyan));
    Body.Dequeue();
    Head = new Pixel(Head.X + 1, Head.Y, '0', ConsoleColor.Red);
    Draw();
    //RightEvent.Invoke();
}
public void Left()
{
    Clear();
    Body.Enqueue(new Pixel(Head.X, Head.Y, '*', ConsoleColor.Cyan));
    Body.Dequeue();
    Head = new Pixel(Head.X - 1, Head.Y, '0', ConsoleColor.Red);

    Draw();
    Thread.Sleep(200);
    //LeftEvent();
}*/
/* public void Up()
 {
     Clear();
     Body.Add(new Pixel(Head.X, Head.Y, '*', ConsoleColor.Cyan));
     Body.RemoveAt(Body.Count-1);
     Head = new Pixel(Head.X, Head.Y - 1, '0', ConsoleColor.Red);
     Draw();
     Thread.Sleep(200);
     UpEvent.Invoke();
 }
 public void Down()
 {
     Clear();
     Body.Add(new Pixel(Head.X, Head.Y, '*', ConsoleColor.Cyan));
     Body.RemoveAt(Body.Count-1);
     Head = new Pixel(Head.X, Head.Y + 1, '0', ConsoleColor.Red);
     Draw();
     Thread.Sleep(200);

     //DownEvent.Invoke();
 }
 public void Right()
 {
     Clear();
     Body.Add(new Pixel(Head.X, Head.Y, '*', ConsoleColor.Cyan));
     Body.RemoveAt(Body.Count-2);
     Head = new Pixel(Head.X + 1, Head.Y, '0', ConsoleColor.Red);
     Draw();
     Thread.Sleep(200);
     //RightEvent.Invoke();
 }
 public void Left()
 {
     Clear();
     Body.Insert(0, new Pixel(Head.X, Head.Y, '*', ConsoleColor.Cyan));
     Body.RemoveAt(Body.Count-1);
     Head = new Pixel(Head.X-1, Head.Y,'0',ConsoleColor.Red);
     Draw();
     Thread.Sleep(200);
     //LeftEvent.Invoke();
 }*/