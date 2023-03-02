using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crash_course_OOP_inharitance
{
    internal class Turtle : Reptile
    {
        public string Name { get; set; }
        public Turtle(string species, float speed, int weight, string environment, string row, string family, string name)
           : base(species, speed, weight, environment, row, family)
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
            Console.WriteLine("No sounds");
        }
    }
}
