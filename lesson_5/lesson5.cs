using System;
using System.IO;

class Weapon{
    private int firingRange;
    private float caliber;
    private int bulletsInMagazine;
    private int maxMagazineSize;
    public void Initialize(int range, float cal, int maxSize){
        if (range <= 0 || cal <= 0 || maxSize <= 0){
            Console.WriteLine("Invalid parameters");
            return;
        }
        firingRange = range;
        caliber = cal;
        maxMagazineSize = maxSize;
        bulletsInMagazine = maxSize;
    }
    public bool Shot(){
        if (bulletsInMagazine > 0){
            bulletsInMagazine--;
            Console.WriteLine("Shot fired!");
            return true;
        }
        else{
            Console.WriteLine("Empty magazine!");
            return false;
        }
    }
    public void Recharge(){
        bulletsInMagazine = maxMagazineSize;
        Console.WriteLine("Reloaded!");
    }
    public void Save(){
        string fileName = "weapon.txt";
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            writer.WriteLine(firingRange);
            writer.WriteLine(caliber);
            writer.WriteLine(bulletsInMagazine);
            writer.WriteLine(maxMagazineSize);
        }
        Console.WriteLine("Weapon saved to file: " + fileName);
    }
    public void Load(){
        string fileName = "weapon.txt";
        using (StreamReader reader = new StreamReader(fileName)){
            firingRange = Convert.ToInt32(reader.ReadLine());
            caliber = Convert.ToSingle(reader.ReadLine());
            bulletsInMagazine = Convert.ToInt32(reader.ReadLine());
            maxMagazineSize = Convert.ToInt32(reader.ReadLine());
        }
        Console.WriteLine("Weapon loaded from file: " + fileName);
    }
}

class Program{
    static void Main(string[] args){
        Weapon gun = new Weapon();
        gun.Initialize(100, 0.9f, 10);
        gun.Shot();
        gun.Recharge();
        gun.Shot();
        gun.Save();
        gun.Load();
    }
}

