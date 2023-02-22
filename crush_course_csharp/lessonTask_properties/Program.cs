namespace lessonTask_properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть назву компанії: ");
            string name = Console.ReadLine();
            Console.Write("Введіть кількість працівників: ");
            int countEmployes = int.Parse(Console.ReadLine());
            Console.Write("Введіть кількість продуктів: ");
            int countProducts = int.Parse(Console.ReadLine());
            Console.WriteLine("Компанія успішно додана!\n" +
                "Тепер потрібно заповнити основну інформацію...\n\n");
            Factory newFactory = new Factory(countEmployes, countProducts){ Name = name };
            Console.WriteLine("\nВсі дані про компанію успішно додані!");
        }
    }
}