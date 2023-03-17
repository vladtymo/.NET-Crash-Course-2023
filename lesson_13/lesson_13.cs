using System;
using System.Collections.Generic;

abstract class CombatVehicle{
    public string Type { get; protected set; }
    public string Model { get; protected set; }
    public int Health { get; protected set; }
    public CombatVehicle(string type, string model, int health){
        Type = type;
        Model = model;
        Health = health;
    }

    public bool IsDestroyed() => Health <= 0;
    public virtual void ShowInfo(){
        Console.WriteLine($"Type: {Type}");
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"Hp: {Health}");
    }
    public abstract int Attack();
    public abstract void Defense(int damage);
}
class Tank : CombatVehicle{
    private int ReloadTime { get; set; }
    private double ShotAccuracy { get; set; }
    private int ArmorThickness { get; set; }
    public Tank(string model, int health, int reloadTime, double shotAccuracy, int armorThickness)
        : base("Tank", model, health){
        ReloadTime = reloadTime;
        ShotAccuracy = shotAccuracy;
        ArmorThickness = armorThickness;
    }
    public override int Attack() => (int)(100 * ShotAccuracy / ReloadTime);
    public override void Defense(int damage) => Health -= Math.Max(0, damage - ArmorThickness);
    public override void ShowInfo(){
        base.ShowInfo();
        Console.WriteLine($"Reload time: {ReloadTime}");
        Console.WriteLine($"Shot accuracy: {ShotAccuracy}");
        Console.WriteLine($"Armor thickness: {ArmorThickness}");
    }
}
class ArmoredCar : CombatVehicle{
    private int NumberOfWeapons { get; set; }
    private int Speed { get; set; }
    public ArmoredCar(string model, int health, int numberOfWeapons, int speed)
        : base("Armored Car", model, health){
        NumberOfWeapons = numberOfWeapons;
        Speed = speed;
    }
    public override int Attack() => 50 * NumberOfWeapons;
    public override void Defense(int damage) => Health -= Math.Max(0, damage - Speed / 2);
    public override void ShowInfo(){
        base.ShowInfo();
        Console.WriteLine($"Number of Weapons: {NumberOfWeapons}");
        Console.WriteLine($"Speed: {Speed}");
    }
}
class AirDefenseVehicle : CombatVehicle{
    private int Range { get; set; }
    private int RateOfFire { get; set; }
    private int Mobility { get; set; }
    public AirDefenseVehicle(string model, int health, int range, int rateOfFire, int mobility)
        : base("Air Defense Vehicle", model, health){
        Range = range;
        RateOfFire = rateOfFire;
        Mobility = mobility;
    }
    public override int Attack() => (150 + Range * (RateOfFire / 10));
    public override void Defense(int damage) => Health -= (int)(damage / (double)Mobility);
    public override void ShowInfo(){
        base.ShowInfo();
        Console.WriteLine($"Range: {Range}");
        Console.WriteLine($"Rate of Fire: {RateOfFire}");
        Console.WriteLine($"Mobility: {Mobility}");
    }
}
class Program{
    static Random random = new Random();
    static CombatVehicle CreateRandomCombatVehicle(){
        int vehicleType = random.Next(3);
        string model = "Model" + random.Next(1000);
        int health = random.Next(50, 151);
        switch (vehicleType)
        {
            case 0:
                int reloadTime = random.Next(1, 6);
                double shotAccuracy = random.Next(1, 101) / 100.0;
                int armorThickness = random.Next(1, 11);
                return new Tank(model, health, reloadTime, shotAccuracy, armorThickness);
            case 1:
                int numberOfWeapons = random.Next(1, 5);
                int speed = random.Next(1, 101);
                return new ArmoredCar(model, health, numberOfWeapons, speed);
            default:
                int range = random.Next(1, 11);
                int rateOfFire = random.Next(1, 11);
                int mobility = random.Next(1, 11);
                return new AirDefenseVehicle(model, health, range, rateOfFire, mobility);
        }
    }
    static bool Round(CombatVehicle bm1, CombatVehicle bm2){
        while (!bm1.IsDestroyed() && !bm2.IsDestroyed()){
            bm2.Defense(bm1.Attack());
            if (!bm2.IsDestroyed()){
                bm1.Defense(bm2.Attack());
            }
        }
        return bm1.IsDestroyed() ? false : true;
    }
    static void Main(string[] args){
        int armySize = random.Next(5, 11);
        List<CombatVehicle> army1 = new List<CombatVehicle>();
        List<CombatVehicle> army2 = new List<CombatVehicle>();
        for (int i = 0; i < armySize; i++){
            army1.Add(CreateRandomCombatVehicle());
            army2.Add(CreateRandomCombatVehicle());
        }
        while (army1.Count > 0 && army2.Count > 0){
            int bm1Index = random.Next(army1.Count);
            int bm2Index = random.Next(army2.Count);
            bool bm1Wins = Round(army1[bm1Index], army2[bm2Index]);
            if (bm1Wins){
                army2.RemoveAt(bm2Index);
                Console.WriteLine("Army 1 wins this round!");
            }
            else{
                army1.RemoveAt(bm1Index);
                Console.WriteLine("Army 2 wins this round!");
            }
        }
        if (army1.Count > 0){
            Console.WriteLine("Army 1 wins the battle!");
        }
        else{
            Console.WriteLine("Army 2 wins the battle!");
        }
    }
}

