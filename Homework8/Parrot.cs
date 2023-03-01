using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_08_inheritance
{
    internal class Parrot : Bird
    {
        public Parrot(string kind,float speed,float weight, string? environment, bool canFly)
            :base(kind,speed,weight,environment,canFly) { }

    }
}
