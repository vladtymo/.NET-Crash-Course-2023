using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12AbstractClasses
{
    internal class Tank : CombatVehicle
    {
        public Tank(String type, string model, int health, int reload, int shotAccuracy, int armorThickness) : base(type, model, health)
        {
            Reload = reload;
            ShotAccuracy = shotAccuracy;
            ArmorThickness = armorThickness;
        }

        public int Reload { get; set; }
        public int ShotAccuracy { get; set; }
        public int ArmorThickness { get; set; }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($", reload - {Reload}, ShotAccuracy - {ShotAccuracy}, ArmorThickness - {ArmorThickness}.");
        }
        public override int Attack()
        {
            return (100*Reload/ShotAccuracy);
        }

        public override void Defense(int damage)
        {
            if (damage<ArmorThickness)
            {
                Health -= 1;
            }
            else
            {
                Health -= damage-ArmorThickness;
            }
        }
    }
}
