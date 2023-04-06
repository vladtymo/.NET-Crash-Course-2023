using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Predmet
    {
        public static int counter=0;
        public readonly int nomer;
        public string Name { get; set; }
        public string OpusPredmetu { get; set; }

        public Predmet(string name,string opusPredmetu)
        {
            ++counter;
            nomer = counter;
            Name = name;
            OpusPredmetu = opusPredmetu;

        }


        public void Info()
        {
            Console.WriteLine($" №{nomer} Predmet: {Name}\t" +
                $"Opus: {OpusPredmetu}\n");
        }


        public void ReSetPredmet(string name, string opusPredmetu)  
        {
            Name = name;
            OpusPredmetu = opusPredmetu;
        }
    }
}
