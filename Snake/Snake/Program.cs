using Snake;
using Snake.Interface;
using System.Numerics;
using System.Security.Cryptography;
using System.Text.Json;

namespace Snake
{
    internal class Program
    {
        public const int width = 70, heigth = 40;
        static void StartGame()
        {
            Console.CursorVisible = false;

            // creating instances
            Console.Write("\n\n\tEnter name: ");
            Player player = new Player( Console.ReadLine());

            Snake snake = new Snake();
            Field field = new Field();
            field.Clear();
            field.Draw();

            Text text = new Text();
            text.Draw();
            text.EndTitel += player.Count;

            Element food = field.FormationtFood(snake);

            while (!snake.IsTouch() && !text.Win())
            {
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
            string loadedJson = File.ReadAllText("data.json");
            List<Player>? loaded = JsonSerializer.Deserialize<List<Player>>(loadedJson);
            loaded.Add(player);
            player.SortList(loaded);
            string jsonToSave = JsonSerializer.Serialize(loaded);
            File.WriteAllText("data.json", jsonToSave);
            Console.SetCursorPosition(0, heigth+2);


            foreach (var item in loaded)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(item);
                Console.WriteLine();
            }

        }
        static void Main(string[] args)
        {
            
            StartGame();
        }
    }
}




/*new Player { NikName = "Bob", Number = 10 },
                new Player { NikName = "Lose", Number = 0 },
                new Player { NikName = "Sem", Number = 5 },
                new Player { NikName = "Tom", Number = 6 },*/


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