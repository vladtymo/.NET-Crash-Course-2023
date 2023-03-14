using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW12
{
    enum CombatVehicleType { Tank, ArmoredCar, AirDefenseVehicle }
    internal abstract class CombatVehicle
    {
        public CombatVehicleType Type { get; set; }
        public string? Model { get; set; }
        public double Health { get; set; }

        public CombatVehicle(CombatVehicleType type, double health)
        {
            this.Type = type;
            this.Health = health;
        }
        public CombatVehicle(CombatVehicleType type, string model, double health)
        {
            this.Type = type;
            this.Model = model;
            this.Health = health;
        }
        
        public bool isDestroyed()
        {
            return Health <= 0;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Type: {Type}\nModel: {Model}\nHealth: {Health}\n");
        }
        public abstract double Attack();
        public abstract void Defense(double damage);
    }

    internal class Tank : CombatVehicle
    {
        public double R { get; set; }
        public double A { get; set; }
        public double T { get; set; }
        
        public Tank(string model, double health, double r, double a, double t)            :base(CombatVehicleType.Tank, model, health)        {
            R = r;
            A = a;
            T = t;
        }
        public Tank(double health, double r, double a, double t)            : base(CombatVehicleType.Tank, health)        {
            R = r;
            A = a;
            T = t;
        }

        public override double Attack()
        {
            return (100 * A / R);
        }
        public override void Defense(double damage)
        {
            Health -= (damage - T);
        }
    }

    internal class ArmoredCar : CombatVehicle
    {
        public int C { get; set; }
        public double S { get; set; }

        public ArmoredCar(string model, double health, int c, double s)            : base(CombatVehicleType.ArmoredCar, model, health)        {
            C = c;
            S = s;
        }
        public ArmoredCar(double health, int c, double s)            : base(CombatVehicleType.ArmoredCar, health)        {
            C = c;
            S = s;
        }

        public override double Attack()
        {
            return (50 * C);
        }
        public override void Defense(double damage)
        {
            Health -= (damage - S / 2);
        }
    }

    internal class AirDefenseVehicle : CombatVehicle
    {
        public double L { get; set; }
        public double R { get; set; }
        public double M { get; set; }

        public AirDefenseVehicle(string model, double health, double l, double r, double m)            : base(CombatVehicleType.AirDefenseVehicle, model, health)        {
            L = l;
            R = r;
            M = m;
        }
        public AirDefenseVehicle(double health, double l, double r, double m)            : base(CombatVehicleType.AirDefenseVehicle, health)        {
            L = l;
            R = r;
            M = m;
        }

        public override double Attack()
        {
            return (150 + L * (R / 10));
        }
        public override void Defense(double damage)
        {
            Health -= (damage / M);
        }
    }
}
