using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace crash_course_abstract
{
    internal class Tank : CombatVehicle
    {
        public float ReloadTime { get; }
        public int ShootAim { get;}
        public int ArmorThickness { get; }

        public Tank(string model, int health, Types type, float reloadTime, int shootAim, int armorThickness) 
            : base(model, health, type)
        {
            ReloadTime = reloadTime;
            ShootAim = shootAim;
            ArmorThickness = armorThickness;
        }

        public override int Attack()
        {
            float attackDamage = (100 * ShootAim) / ReloadTime;
            return (int)attackDamage;
        }

        public override int Defence(int damage)
        {
            int damageReceived = damage - ArmorThickness;
            Health = damage - ArmorThickness;
            IsDestroyed();
            return damageReceived;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Reload time: {ReloadTime}\n" +
                $"Shoot aim: {ShootAim}\n" +
                $"Armor Thickness: {ArmorThickness}\n");
        }
    }
}
