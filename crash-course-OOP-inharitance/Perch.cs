using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crash_course_OOP_inharitance
{
    internal class Perch : Fish
    {
        public string Name { get; set; }

        public Perch(string species, float speed, int weight, string environment, string fishClass, string size, string row, string name) 
        :base(species, speed, weight, environment, fishClass, size, row)
        {
            Name = name;
        }

        public new void ShowInfo()
        {
            Console.WriteLine($"---{Name}---");
            base.ShowInfo();
        }

        public new void MakeSound()
        {
            Console.WriteLine("Silence");
        }
    }
}
