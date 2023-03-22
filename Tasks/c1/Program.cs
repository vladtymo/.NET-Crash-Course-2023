namespace c1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Title = "Task 1 ";
            Console.WriteLine("\n\n\n\t\t\tПочаток введення дати");

            Console.Write("\tВведіть день: ");
            int day = int.Parse(Console.ReadLine());
            Console.Write("\tВведіть місяць: ");
            int mouth = int.Parse(Console.ReadLine());
            Console.Write("\tВведіть рік: ");
            int year = int.Parse(Console.ReadLine());


            Console.WriteLine($"\n\n\t{day}/{mouth}/{year}");
           
        }
    }
}