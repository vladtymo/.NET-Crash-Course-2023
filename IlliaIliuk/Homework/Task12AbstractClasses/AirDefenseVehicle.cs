using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12AbstractClasses
{ 
    internal class AirDefenseVehicle : CombatVehicle
    {
        public AirDefenseVehicle(String type, string model, int health, int reload, int rangeOfAction, int mobility) : base(type, model, health)
        { 
            Reload = reload;
            RangeOfAction = rangeOfAction;
            Mobility = mobility;
        }


        public int Reload { get; set; }
        public int RangeOfAction { get; set; }
        public int Mobility { get; set; }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($", reload - {Reload}, rangeOfAction - {RangeOfAction}, mobility - {Mobility}.");
        }
        public override int Attack()
        {
            return (150 + RangeOfAction * (Reload / 10));
        }

        public override void Defense(int damage)
        {
            Health -= damage / Mobility;
        }
    }
}
