using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HW5
{
    
    internal class Weapon
    {
        private const string file = "Weapon.txt";
        private int range = 120;
        private double caliber = 5.56;
        public int store = 0;
        private int storeSize = 30;

        public void Initialize(int range, double caliber, int storeSize)
        {
            this.range = range;
            this.caliber = caliber;
            this.storeSize = storeSize;
            Recharge();
            Console.WriteLine("Weapon initialized and recharged...");
            Print();
        }
        public bool Shot()
        {
            if (store == 0) { Console.WriteLine("Weapon has 0 bullets in the store..."); Recharge(); return false; }
            else { store -= 1; Console.WriteLine($"Weapon just shot...\nStore: {store}"); return true; }
        }
        public void Recharge()
        {
            store = storeSize;
            Console.WriteLine($"Weapon recharged...\nStore: {store}");
        }
        public void Print()
        {
            Console.WriteLine($"Weapon info:\nRange: {this.range};\nCaliber: {this.caliber};\nStore size: {this.storeSize};\nStore: {this.store}.\n");
        }
        public async void Save()
        {
            string[] lines = { this.range.ToString(), this.caliber.ToString(), this.storeSize.ToString(), this.store.ToString() };
            await File.WriteAllLinesAsync(file, lines);
            Console.WriteLine("Weapon has been saved...");
        }
        public void Load()
        {
            string[] lines = File.ReadAllLines(file);
            this.range = int.Parse(lines[0]);
            this.caliber = double.Parse(lines[1]);
            this.storeSize = int.Parse(lines[2]);
            this.store = int.Parse(lines[3]);
            Console.WriteLine("Weapon has been loaded...");
            Print();
        }
    }
}
