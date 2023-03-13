using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crash_course_abstract
{
    internal class ArmoredCar : CombatVehicle
    {
        public int WeaponAmount { get; set; }
        public int Speed { get; set; }

        public ArmoredCar(string model, int health, Types type, int weaponAmount, int speed) : base(model, health, type)
        {
            WeaponAmount = weaponAmount;
            Speed = speed;
        }

        public override int Attack()
        {
            int attackDamage = 50 * WeaponAmount;
            return attackDamage;
        }

        public override int Defence(int damage)
        {
            int damageReceived = damage - Speed / 2;
            IsDestroyed();
            return damageReceived;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Weapon amount: {WeaponAmount}\n" +
                $"Speed: {Speed}\n");
        }
    }
}
