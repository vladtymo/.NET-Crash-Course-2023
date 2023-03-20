using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_12_HW_abstract
{
    public class ArmoredCar : CombatVehicle
    {
        public int CountOfWeapons { get; set; }
        public double Speed { get; set; }

        public ArmoredCar(string model, double health) : base("Armored Car")
        {
            Model = model;
            Health = health;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Count of weapons: {CountOfWeapons}\n" +
                $"Speed: {Speed}");
        }

        public override double Attack()
        {
            return 50* CountOfWeapons;
        }

        public override void Defance(double damage)
        {
            Health -= (damage - (Speed / 2));
        }
    }
}
