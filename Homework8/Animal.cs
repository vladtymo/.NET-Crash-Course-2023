using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_08_inheritance
{
    internal class Animal
    {
        public string Kind { get; set; }
        public float Speed { get; set; }
        public float Weight { get; set; }
        public string? LivingEnvironment { get; set; }
        public Animal(string kind, float speed, float weight, string? environment)
        {
            Kind = kind;
            Speed = speed;
            Weight = weight;
            LivingEnvironment = environment;
        }
        public void Move()
        {
            Console.WriteLine("I'm moving!");
        }
        public void MakeSound()
        {
            Console.WriteLine("I can make sounds!");
        }

        public void Show()
        {
            Console.WriteLine($"Kind :{Kind}, Speed: {Speed}, Weight: {Weight}, Living environment: {LivingEnvironment}");
        }
    }
}
