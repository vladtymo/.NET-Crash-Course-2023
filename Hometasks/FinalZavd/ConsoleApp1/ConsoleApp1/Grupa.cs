using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Grupa
    {

        public string Name { get; set; }
        public int Kurs { get; set; }
        public List<Student> Students { get; set; }


        public Grupa(string name, int kurs)
        {
            Name = name;
            Kurs = kurs;
            Students = new List<Student>();

            

        }

        public void Info()
        {
            Console.WriteLine($"Grupa: {Name}\n" +
                $"Kurs: {Kurs}\n" +
                $"Students:");
            foreach (var item in Students)
            {
                Console.WriteLine(item.FirstName+" "+item.LastName);
            }
        }
    }
}
