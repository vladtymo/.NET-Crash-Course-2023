using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_08_inheritance
{
    internal class Reptile : Animal
    {
        public bool IsColdBlooded { get; set; }

        public Reptile(string kind, float speed, float weight, string? environment, bool isColdBlooded)
            : base(kind, speed, weight, environment) { IsColdBlooded = isColdBlooded; }
        public void ColdOrWarmBloodet()
        {
            Console.WriteLine($"I am {(IsColdBlooded ? "cold" : "warm ")} blooded");
        }
        public void MakeNewSound()
        {
            Console.WriteLine("The Reptile is hissing");
        }
    }
}
