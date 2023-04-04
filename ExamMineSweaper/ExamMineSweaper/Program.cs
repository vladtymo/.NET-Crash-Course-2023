
namespace ExamMineSweaper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Minesweeper!");
            Console.Write("Enter number of rows: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter number of columns: ");
            int cols = int.Parse(Console.ReadLine());

            Console.Write("Enter number of mines: ");
            int mines = int.Parse(Console.ReadLine());

            Game game = new Game(rows, cols, mines);
            game.Start();

            Console.ReadKey();
        }
    }
}
