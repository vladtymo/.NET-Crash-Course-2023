using System;
using System.IO;

public class Task_5
{
    class Weapon
    {
        int range;
        double caliber;
        int maxSize;
        int bullets;

        public Weapon(){ Initialize(); }
        public void Initialize(int range = 100, double caliber = 5.56 , int maxSize = 15,int bullets = 0)
        {
            this.range = range;
            this.caliber = caliber;
            this.maxSize = maxSize;
            this.bullets = bullets;
        }
        public bool Shot()
        {
            if (bullets > 0)
            {
                Console.WriteLine("\n\n\t\t Пау-пау");
                bullets--;
                return true;
            }

            Console.WriteLine("\n\n\t\tКлик-клик. Магазин пустий");
            return false;
        }

        public void Recharge()
        {
            bullets = maxSize;
            Console.WriteLine("\n\n\t\tЧик-чик. Магазин повний");
        }
        public void Save()
        {
            string path = @"C:\Users\Svyat\Desktop\Melnychuk_Tasks\Task_5\save.txt";
            
        }
        public void Load()
        { }
    }

    public static void Main(string[] args)
    {


        Weapon weapon = new Weapon();


        weapon.Shot();
        weapon.Recharge();
        weapon.Shot();
        Console.ReadKey();
    }
}
