namespace task_5
{
    class Weapon
    {
        int maxNumberBullet;
        int flightRange;
        int numberBullet;
        double caliber;
        public Weapon()
        {
            maxNumberBullet = 0;
            flightRange = 0;
            numberBullet = 0;
            caliber = 0;
        }
        public void Initialize(int maxNumberBullet, double caliber, int flightRange)
        {
            this.caliber = caliber > 0 ? caliber : 0;
            this.maxNumberBullet = maxNumberBullet > 0 ? maxNumberBullet : 0;
            this.flightRange = flightRange > 0 ? flightRange : 0;
        }
        public void Recharge(int numberBullet)
        {
            if (numberBullet <= maxNumberBullet)
            {
                this.numberBullet = numberBullet;
                Console.WriteLine("Weapon recharge");
            }
            else
            {
                Console.WriteLine("Too many bullets. The remains are thrown away");
                this.numberBullet = maxNumberBullet;

            }

        }

        public void Shot()
        {
            if (numberBullet >= 1)
            {
                Console.WriteLine("Shot!!!!");
                --numberBullet;
            }
            else
                Console.WriteLine("Not enough bullets. Recharge");
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Weapon subGunMachine = new Weapon();
            Weapon pistol = new Weapon();
            subGunMachine.Initialize(20, 5.56, 1000);
            pistol.Initialize(12, .45, 200);
            //shot without bullets
            pistol.Shot();
            //Recharge gun 
            subGunMachine.Recharge(2);
            //Shot with bullets
            subGunMachine.Shot();
            //Shot with bullets
            subGunMachine.Shot();
            //Shot without bullets
            subGunMachine.Shot();
            //Recharge pistol with excess bullets
            pistol.Recharge(66);
            pistol.Shot();
            pistol.Shot();
        }
    }
}