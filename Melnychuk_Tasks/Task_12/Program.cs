using System;
using System.ComponentModel;
using System.Runtime.Intrinsics.X86;
using static Task1;


public class Task1
{
    public abstract class CombatVehicle
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public int Health { get; set; }

        public CombatVehicle(string type, string model, int health)
        {
            Type = type;
            Model = model;
            Health = health;
        }

        public bool IsDestroyed()
        {
            return Health <= 0;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Type: {Type} | Model: {Model} | Health: {Health}");
        }

        public abstract int Attack();
        public abstract void Defense(int damage);
    }

    public class Tank : CombatVehicle
    {
        public int RechargeTime { get; set; }
        public int ShotAccuracy { get; set; }
        public int ArmorThickness { get; set; }

        public Tank(string type, string model, int health, int rechargeTime, int shotAccuracy, int armorThickness)
            : base(type, model, health)
        {
            RechargeTime = rechargeTime;
            ShotAccuracy = shotAccuracy;
            ArmorThickness = armorThickness;
        }

        public override int Attack()
        {
            return 100 * ShotAccuracy / RechargeTime;
        }

        public override void Defense(int damage)
        {
            Health -= (damage - ArmorThickness);
            if (Health < 0) Health = 0;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Recharge Time: {RechargeTime} | Shot Accuracy: {ShotAccuracy} | Armor Thickness: {ArmorThickness}");
        }
    }
    public class ArmoredCar : CombatVehicle
    {
        public int NumberOfWeapons { get; set; }
        public int Speed { get; set; }

        public ArmoredCar(string type, string model, int health, int numberOfWeapons, int speed)
            : base(type, model, health)
        {
            NumberOfWeapons = numberOfWeapons;
            Speed = speed;
        }

        public override int Attack()
        {
            return 50 * NumberOfWeapons;
        }

        public override void Defense(int damage)
        {
            Health -= (damage - Speed / 2);
            if (Health < 0) Health = 0;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Number of Weapons: {NumberOfWeapons} | Speed: {Speed}");
        }
    }


    public class AirDefenseVehicle : CombatVehicle
    {
        public int RangeOfAction { get; set; }
        public int RateOfFire { get; set; }
        public int Mobility { get; set; }

        public AirDefenseVehicle(string type, string model, int health, int rangeOfAction, int rateOfFire, int mobility)
            : base(type, model, health)
        {
            RangeOfAction = rangeOfAction;
            RateOfFire = rateOfFire;
            Mobility = mobility;
        }

        public override int Attack()
        {
            return (150 + RangeOfAction * (RateOfFire / 2));
        }

        public override void Defense(int damage)
        {
            Health -= damage / Mobility;
            if (Health < 0) Health = 0;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Range of Action: {RangeOfAction}|  RateOfFire: {RateOfFire} | Mobility: {Mobility}\n");
        }


    }
    public class TestSimulation
    {
        public static void Round(CombatVehicle bm1, CombatVehicle bm2)
        {
            bm1.Defense(bm2.Attack());
            bm2.Defense(bm1.Attack());
        }
    }
    public static bool War(ref CombatVehicle bm1, ref CombatVehicle bm2)
    {
        Console.WriteLine("Before the battle:");
        bm1.ShowInfo();
        bm2.ShowInfo();
        Console.WriteLine();

        Console.WriteLine("The battle begins:");
        int round = 1;
        while (!bm1.IsDestroyed() && !bm2.IsDestroyed())
        {
            Console.WriteLine($"Round {round}:");
            TestSimulation.Round(bm1, bm2);
            bm1.ShowInfo();
            bm2.ShowInfo();
            Console.WriteLine();
            round++;
        }

        Console.WriteLine("After the battle:");
        bm1.ShowInfo();
        bm2.ShowInfo();
        Console.WriteLine();

        if (bm1.Health == 0) return true; else return false;
    }

    public static void Main(string[] args)
    {
        CombatVehicle tank = new Tank("Tank", "T-34", 5000, 5, 10, 10);
        CombatVehicle armoredCar = new ArmoredCar("Armored Car", "BRDM-2", 2000, 3, 120);
        CombatVehicle airDefenseVehicle = new AirDefenseVehicle("Air Defense Vehicle", "S-300", 8000, 20, 6, 2);


        War(ref tank, ref armoredCar);

        List<CombatVehicle> army1 = new List<CombatVehicle>();
        List<CombatVehicle> army2 = new List<CombatVehicle>();

        Random rnd = new Random();

        for (int i = 0; i < 3; i++)
        {
            int type = rnd.Next(1, 4);
            switch (type)
            {
                case 1:
                    army1.Add(new Tank("Tank_1", "T-34", rnd.Next(3000, 6000), rnd.Next(3, 7), rnd.Next(10, 15), rnd.Next(8, 13)));
                    army2.Add(new Tank("Tank_2", "M1A2 Abrams", rnd.Next(3000, 6000), rnd.Next(3, 7), rnd.Next(10, 15), rnd.Next(8, 13)));
                    break;
                case 2:
                    army1.Add(new ArmoredCar("Armored Car_1", "BRDM-2", rnd.Next(1000, 3000), rnd.Next(2, 6), rnd.Next(60, 120)));
                    army2.Add(new ArmoredCar("Armored Car_2", "Stryker", rnd.Next(1000, 3000), rnd.Next(2, 6), rnd.Next(60, 120)));
                    break;
                case 3:
                    army1.Add(new AirDefenseVehicle("Air Defense Vehicle_1", "S-300", rnd.Next(5000, 12000), rnd.Next(10, 30), rnd.Next(4, 9), rnd.Next(1, 4)));
                    army2.Add(new AirDefenseVehicle("Air Defense Vehicle_2", "Patriot", rnd.Next(5000, 12000), rnd.Next(10, 30), rnd.Next(4, 9), rnd.Next(1, 4)));
                    break;
            }
        }


        int index1;
        int index2;
        bool check;

        while (army1.Count != 0 && army2.Count != 0)
        {
            index1 = rnd.Next(0, army1.Count);
            index2 = rnd.Next(0, army2.Count);
            var task1 = army1[index1];
            var task2 = army2[index2];
            check = War(ref task1, ref task2);
            if (check) { army1.Remove(task1); } else { army2.Remove(task2); }

        }


        if (army1.Count != 0) { Console.WriteLine("Army1 win"); }
        if (army2.Count != 0) { Console.WriteLine("Army2 win"); }


        Console.ReadKey();


    }


}