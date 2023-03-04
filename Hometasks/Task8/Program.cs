using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Golub golub = new Golub("Птах", 20, 1, "Помірні широти", "Хлібні крихти", 0.5, "Жора");
            Turtle turtle = new Turtle("Земноводне", 1, 15, "Вода і земля поблизу води", 1, "Прісноводна", "Донателло");
            Okun okun = new Okun("Риба", 5, 3, "Водойми", "Прісноводна", "Хижа", "Вова");
            golub.Show();
            Console.WriteLine();
            turtle.Show();
            Console.WriteLine();
            okun.Show();
        }
    }
}
