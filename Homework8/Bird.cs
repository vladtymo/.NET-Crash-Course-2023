using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_08_inheritance
{
    internal class Bird : Animal
    {
            public bool CanFly { get; set; }
            public Bird(string kind, float speed, float weight, string? environment, bool canFly)
                : base(kind, speed, weight, environment) { CanFly = canFly; }
            public void Fly()
            {
                Console.WriteLine($"I {(CanFly ? "can" : "can`t")} fly");
            }
            public void MakeNewSound()
            {
                Console.WriteLine("Tsvin-tsvirin");
            }
    }
}
