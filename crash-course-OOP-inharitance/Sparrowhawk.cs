using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crash_course_OOP_inharitance
{
    internal class Sparrowhawk : Bird
    {
        public string Name { get; set; }
        public Sparrowhawk(string species, float speed, int weight, string environment, string fatherColor, string foodSpecial, string order, bool isPreator, string name)
            : base(species, speed, weight, environment, fatherColor, foodSpecial, order, isPreator)
        {
            Name = name;
        }

        public new void MakeSound()
        {
            Console.WriteLine("IAAAAAAAAAAAAAAAAAAA!");
        }

        public new void ShowInfo()
        {
            Console.WriteLine($"---{Name}---");
            base.ShowInfo();
        }
    }
}
