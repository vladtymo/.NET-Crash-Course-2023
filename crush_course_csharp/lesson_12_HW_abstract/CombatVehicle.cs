using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_12_HW_abstract
{
    public abstract class CombatVehicle
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public double Health { get; set; }

        public CombatVehicle(string type, string model, double health) : this(type)
        {
            Type = type;
            Model = model;
            Health = health;
        }

        public CombatVehicle(string type)
        {
            if (!string.IsNullOrWhiteSpace(type))
                Type = type;
            else
                Type = "No type";
        }

        public bool IsDestoyed()
        {
            if (Health > 0) return false;
            else return true;
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Type: {Type}\n" +
                $"Model: {Model}\n" +
                $"Health: {Math.Round(Health,2)}");
        }
        public abstract double Attack();
        public abstract void Defance(double damage);
    }
}
