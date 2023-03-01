using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_08_inheritance
{
    internal class Fish : Animal
    {
        public bool IsSaltWater { get; set; }
        public Fish(string kind, float speed, float weight, string? environment,bool isSaltWater)
        :base(kind,speed,weight,environment) { IsSaltWater = isSaltWater; }

        public void TypeWater()
        {
            Console.WriteLine($"I live in {(IsSaltWater ? "salty water" : "not salty water")}");
        }
        public void MakeNewSound()
        {
            Console.WriteLine("Byl-byl-byl");
        }
    }
}
