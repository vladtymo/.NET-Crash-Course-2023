using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12AbstractClasses
{
    internal class ArmoredCar : CombatVehicle
    {
        public ArmoredCar(String type, string model, int health, int speed, int numberOfWeapon) : base(type, model, health)
        {
            Speed = speed;
            NumberOfWeapon = numberOfWeapon;
        }

        public int Speed { get; set; }
        public int NumberOfWeapon { get; set; }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($", Speed - {Speed}, NumberOfWeapon - {NumberOfWeapon}.");
        }
        public override int Attack()
        {
            return (50 * NumberOfWeapon);
        }

        public override void Defense(int damage)
        {
            if (damage<Speed/2)
            {
                Health -= 1;
            }
            else
            {
                Health -= damage - Speed/2;
            }
        }
    }
}
