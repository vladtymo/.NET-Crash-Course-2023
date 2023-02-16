using Microsoft.VisualBasic;
using System;
using System.Drawing;

namespace ConsoleApp2
{
    class Weapon
    {
        private float calibr;
        private int distance;
        private int countBullets;
        private int maxCount;
        public void Showinfo()
        {
            Console.WriteLine($"Калiбер: {calibr}\n" +
                $"Дистанцiя вистрiлу: {distance}\n" +
                $"Кiлькiсть патронiв в магазинi: {countBullets}\n" +
                $"Максимальна кiлькiсть патронiв в магазинi: {maxCount}" +
                $"\n");
        }
        public void Initialize(int range, float caliber, int maxSize)
        {
            countBullets = maxSize;
            distance = range;
            calibr= caliber;
            maxCount = maxSize;
        }
        public bool Shot()
        {
            if (countBullets > 0)
            {
                countBullets -= 1;
                Console.WriteLine($"Вистрелили один патрон, залишок патронiв в магазинi {countBullets}");
                return true;
            }
            else if (countBullets == 0)
            {
                Console.WriteLine("Порожнiй магазин");
                return false;
            }
            else return false;
        }
        public void Recharge()
        {
            if (countBullets < maxSize1)
            {
                countBullets += 1;
                Console.WriteLine($"Виконується перезарядка - Додаю в магазин 1 патрон, кiлькiсть патронiв в магазинi {countBullets}");
            }
            else if (countBullets == maxSize1)
                Console.WriteLine($"Виконується перезарядка - Магазин повний, неможливо додати ще один патрон");

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Weapon rifle = new Weapon();
            rifle.Initialize(25, 7.5F, 40); //(range,calibr,maxsize)
            rifle.Showinfo();
            rifle.Shot(); rifle.Shot(); rifle.Shot(); rifle.Shot(); rifle.Shot();
            rifle.Recharge(); rifle.Recharge(); rifle.Recharge(); rifle.Recharge(); rifle.Recharge(); rifle.Recharge(); rifle.Recharge(); rifle.Recharge();
            rifle.Shot();
            rifle.Shot();
            Console.WriteLine("\n");
            Weapon gun = new Weapon();
            gun.Initialize(35, 10.5F, 20); //(range,calibr,maxsize)
            gun.Showinfo();
            gun.Shot(); gun.Shot(); gun.Shot(); gun.Shot(); gun.Shot();
            gun.Recharge(); gun.Recharge(); gun.Recharge(); gun.Recharge(); gun.Recharge(); gun.Recharge(); gun.Recharge(); gun.Recharge();
            gun.Shot();
        }
    }

}