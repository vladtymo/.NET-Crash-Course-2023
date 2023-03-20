using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_12_HW_abstract
{
    public class Tank : CombatVehicle
    {
        public int ReloadTime { get; set; }
        public double ShotAccurancy { get; set; }
        public double ArmorThinkness { get; set; }

        public Tank(string model, double health) : base("Tank")
        {
            Model = model;
            Health = health;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Reload Time: {ReloadTime}\n" +
                $"Shot Accurancy: {ShotAccurancy}\n" +
                $"Armor Thinkness: {ArmorThinkness}");
        }

        public override double Attack()
        {
            return 100 * ShotAccurancy / ReloadTime; 
        }

        public override void Defance(double damage)
        {
            Health -= (damage - ArmorThinkness);
        }
    }
}
