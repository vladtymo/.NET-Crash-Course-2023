using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вгадай число від 1 до 10");

            Random random = new Random();
            int zagchjis = random.Next(1, 11);
            Console.WriteLine(zagchjis);
            bool vgad = true;
            int k = 0;
            while (vgad)
            {
                int x = Convert.ToInt32(Console.ReadLine());
                ++k;
                if (x == zagchjis)
                {
                    Console.WriteLine("Вгадав! Було загадано число " + zagchjis);
                    vgad = false;
                }
                else
                {
                    Console.WriteLine("Не вгадав. Спробуй ще раз");
                }
            }
            Console.WriteLine("К-ть спроб: " + k);
        }
    }
}
