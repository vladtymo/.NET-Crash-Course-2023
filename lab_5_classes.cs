namespace lab_05_classes
{
    internal class lab_5_classes
    {
        class Weapon
        {
            private int shotRange;
            private float caliber;
            private int numberOfBullets;
            private static int maxNumberOfBullets = 10;
            public Weapon()
            {
                shotRange = 0;
                caliber = 0;
                numberOfBullets = 0;
            }
            public void Initialize(int range, float caliber, int maxSize)
            {
                if (range < 0) this.shotRange = 0;
                else this.shotRange = range;
                if (caliber < 0) this.caliber = 0;
                else this.caliber = caliber;
                if (maxSize > maxNumberOfBullets) this.numberOfBullets = maxNumberOfBullets;
                else this.numberOfBullets=maxSize;
            }
            public bool Shot()
            {
                bool shot = false;
                if (numberOfBullets != 0) { --numberOfBullets; shot = true; }
                return shot;
            }
            public void Recharge()
            {
                numberOfBullets = maxNumberOfBullets;
            }
            public void PrintInfo()
            {
                
                Console.WriteLine($"Shoot range : {shotRange}" +
                    $"\nCaliber : {caliber} " +
                    $"\nNumber of bullets : {numberOfBullets} " +
                    $"\nMaximum numbers : {maxNumberOfBullets}");
            }

        }
        static void Main(string[] args)
        {
            Weapon weapon = new Weapon();
            weapon.PrintInfo();
            Console.WriteLine();
            weapon.Initialize(250, 22f, 4);
            weapon.PrintInfo();
            Console.WriteLine();
            Console.WriteLine(weapon.Shot() ? "The shot was fired" : "There was no shot");
            Console.WriteLine(weapon.Shot() ? "The shot was fired" : "There was no shot");
            Console.WriteLine(weapon.Shot() ? "The shot was fired" : "There was no shot");
            Console.WriteLine(weapon.Shot() ? "The shot was fired" : "There was no shot");
            Console.WriteLine(weapon.Shot() ? "The shot was fired" : "There was no shot");
            weapon.PrintInfo();
            Console.WriteLine();
            weapon.Recharge();
            weapon.PrintInfo();
            Console.WriteLine();
        }
    }
}