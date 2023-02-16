using System;
using System.IO;

namespace ConsoleApp1
{
    class Weapon
    {
        int daln_postrilu;
        float kalibr;
        int p_in_m;
        int Max_p_in_m;


        public Weapon(int a, float b, int c, int d)
        {
            daln_postrilu = a;
            kalibr = b;
            p_in_m = c;
            Max_p_in_m = d;
        }

        public void Initialize(int range, float caliber, int maxSize)
        {
            daln_postrilu = range;
            kalibr = caliber;
            Max_p_in_m = maxSize;

        }

        public bool Shot()
        {
            if (p_in_m > 0)
            {
                --p_in_m;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Recharge()
        {
            p_in_m = Max_p_in_m;
        }

        public void Print()
        {
            Console.WriteLine($"Дальність пострілу: {daln_postrilu}\n" +
                $"Калібр: {kalibr}\n" +
                $"К-ть куль в магазині: {p_in_m}\n" +
                $"Розмір магазину: {Max_p_in_m}");
        }


        public void Save()
        {
            using (StreamWriter writer = new StreamWriter("text.txt"))
            {
                writer.WriteLine(daln_postrilu);
                writer.WriteLine(kalibr);
                writer.WriteLine(p_in_m);
                writer.WriteLine(Max_p_in_m);
            }
        }

        public Weapon Load()
        {
            using (StreamReader reader = new StreamReader("text.txt"))
            {
                int a = int.Parse(reader.ReadLine());
                float b = float.Parse(reader.ReadLine());
                int c = int.Parse(reader.ReadLine());
                int d = int.Parse(reader.ReadLine());
                return new Weapon(a, b, c, d);

            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Weapon a = new Weapon(0, 0, 0, 0);
            a.Initialize(77, 9, 9);
            a.Recharge();
            a.Print();
            a.Save();

            Console.WriteLine();

            Weapon b = a.Load();
            b.Print();


        }
    }
}
