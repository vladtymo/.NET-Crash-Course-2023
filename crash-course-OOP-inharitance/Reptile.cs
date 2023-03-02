using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crash_course_OOP_inharitance
{
    internal class Reptile : Animal
    {
        public string Row { get; set; }
        public string Family { get; set; }

        public Reptile(string species, float speed, int weight, string environment, string row, string family)
           : base(species, speed, weight, environment)
        {
            Row = row;
            Family = family;
        }


    }

}
