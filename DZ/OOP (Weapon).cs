using System;
using System.IO;

namespace Code_Coach_Challenge
{

    class Weapon
    {
        int range;
        float caliber;
        int maxSize;
        public int amount;


        public void initialize(int range,float caliber,int maxSize)
        {
            this.range = range;
            this.caliber = caliber;
            this.maxSize = maxSize;
            amount = maxSize;
            Console.WriteLine($"The max distance: {range} caliber: {caliber}" +
                $" max size {maxSize}  ");


        }
        public bool shot()
        {
           -- amount;
            return amount == 0 ? false : true;
        }
        public void reCharge()
        {
            amount = maxSize;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Weapon weapon = new Weapon();
            weapon.initialize(300,5.56f,30);
            weapon.shot();
            weapon.shot();
            weapon.shot();
            weapon.reCharge();


            Console.WriteLine(weapon.amount);
            




        }




    }
}


