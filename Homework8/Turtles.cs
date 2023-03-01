using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_08_inheritance
{
    internal class Turtles : Reptile
    {
        public Turtles() : base("Turtles",35f,150f,null,true) { }
        public Turtles(string kind, float speed, float weight, string? environment, bool isColdBlooded)
            : base(kind, speed, weight, environment, isColdBlooded) { }
    }
}
