using System;


namespace ConsoleApp1
{

    class Morozilka
    {

        private readonly string name;
        private bool power;
        private readonly double? obyem;
        private const int maxTemp = 0;
        private int? minTemp;
        private int? temp;
        private regum reg;
        enum regum { LOW, MEDIUM, HIGH, SUPERFRIZ }

        public Morozilka()
        {


        }


        public Morozilka(bool p, string n, double o)
        {
            power = p;
            name = n;
            if (o > 0)
            {
                obyem = o;
            }
            else
            {
                obyem = null;
            }
        }

        public Morozilka(bool p, string n, double o, int m, int t, int r)
        {
            power = p;


            name = n;



            if (o > 0)
            {
                obyem = o;
            }
            else
            {
                obyem = null;
            }



            if (m < 0)
            {
                minTemp = m;
            }
            else
            {
                minTemp = null;
            }



            if (t < maxTemp & t > minTemp)
            {
                temp = t;
            }
            else
            {
                temp = maxTemp;
            }

            switch (r)
            {
                case 1:
                    reg = regum.LOW;
                    break;
                case 2:
                    reg = regum.MEDIUM;
                    break;
                case 3:
                    reg = regum.HIGH;
                    break;
                case 4:
                    reg = regum.SUPERFRIZ;
                    break;
                default:
                    reg = regum.LOW;
                    break;
            }
        }

        public void OnOff()
        {
            power = !power;
        }

        public void AddTemp()
        {
            if (temp < maxTemp)
            {
                ++temp;
            }
            else
            {
                Console.WriteLine("Максимальна температура!!!");
            }

        }

        public void MinusTemp()
        {
            if (temp > minTemp)
            {
                --temp;
            }
            else
            {
                Console.WriteLine("Мінімальна температура!!!");
            }

        }

        public void SwapRegum(int r)
        {
            switch (r)
            {
                case 1:
                    reg = regum.LOW;
                    break;
                case 2:
                    reg = regum.MEDIUM;
                    break;
                case 3:
                    reg = regum.HIGH;
                    break;
                case 4:
                    reg = regum.SUPERFRIZ;
                    break;
                default:

                    break;
            }
        }


        public void PrintInfo()
        {
            Console.WriteLine();
            if (power)
            {
                Console.WriteLine($"Морозіловка ON\n" +
                $"Назва морозіловки: {name}\n" +
                $"Об'єм морозіловки: {obyem}\n" +
                $"Максимальна температура: {maxTemp}\n" +
                $"Мінімальна температура: {minTemp}\n" +
                $"Задана температура: {temp}\n" +
                $"Режим роботи: {reg}");

            }
            else
            {
                Console.WriteLine("Морозіловка OFF");
            }
            Console.WriteLine();
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Morozilka a = new Morozilka();
            a.PrintInfo();


            Morozilka b = new Morozilka(true, "Bosh", 5);
            b.PrintInfo();


            Morozilka c = new Morozilka(true, "Samsung", 7, -25, -5, 3);
            c.PrintInfo();

            c.AddTemp();
            c.AddTemp();
            c.AddTemp();
            c.AddTemp();
            c.AddTemp();
            c.AddTemp();
            c.AddTemp();

            c.PrintInfo();

            c.MinusTemp();
            c.MinusTemp();
            c.MinusTemp();
            c.MinusTemp();
            c.MinusTemp();

            c.PrintInfo();

            c.SwapRegum(1);

            c.PrintInfo();

            c.OnOff();

            c.PrintInfo();

        }
    }
}
