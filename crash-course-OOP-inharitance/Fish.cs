using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crash_course_OOP_inharitance
{
    internal class Fish : Animal
    {
        public string FishClass { get; set; }
        public string Size { get; set; }
        public string Row { get; set; }

        public Fish(string species, float speed, int weight, string environment, string fishClass, string size, string row)
           : base(species, speed, weight, environment)
        {
            FishClass = fishClass;
            Size = size;
            Row = row;
        }
    }
}
