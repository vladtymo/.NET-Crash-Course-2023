using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crash_course_abstract
{
    public enum Types { Artillery = 1, LightVehicle, HardVehicle };

    internal abstract class CombatVehicle
    {
        public string Model { get; }
        public int Health { get; set; }
        public Types Type { get; }

        public CombatVehicle(string model, int health, Types type)
        {
            Model = model;
            Health = health;
            Type = type;
        }

        public bool IsDestroyed()
        {
            if (Health <= 0)
            {
                Health = 0;
                return true;
            }

            return false;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"----{Model}----\n" +
                $"Current health: {Health}\n" +
                $"Type: {Type}");
        }

        public abstract int Attack();

        public abstract int Defence(int damage);
    }
}
