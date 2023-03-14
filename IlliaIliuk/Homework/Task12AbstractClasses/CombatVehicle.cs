using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12AbstractClasses
{
    internal abstract class CombatVehicle
    {
        protected CombatVehicle(String type, string model, int health)
        {
            Type = type;
            Model = model;
            Health = health;
        }

        public String Type { get; set; }
        public String Model { get; set; }
        public int Health { get; set; }

        public bool IsDestroyed() 
        {
            return Health <= 0;
        }

        public virtual void ShowInfo()
        {
            Console.Write($"Type - {Type}, model - {Model}, health - {Health}");
        }
        public abstract int Attack();
        public abstract void Defense(int damage);
    }
}
