namespace dz_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Weapon AK47 = new Weapon();
            AK47.Initialize(200,7.5f,30);
            /*for (int i = 0; i < 35; i++)
            {
                AK47.Shoot();
            }
            */

            Weapon revolver = new Weapon();
            revolver.Initialize(40, 7.62f, 6);
            for (int i = 0; i < 7; i++)
            {
                revolver.Shoot();
            }
            revolver.Recharge();
            for (int i = 0; i < 7; i++)
            {
                revolver.Shoot();
            }
        }
    }

    class Weapon
    {
        int range;
        float caliber;
        int bulletCount;
        int bulletMax;

        public void Initialize(int range, float caliber, int maxSize)
        {
            this.range = (range > 1 ? range : 1);
            this.caliber = (caliber > 0.1f ? caliber : 0.1f);
            bulletMax = (maxSize > 1 ? maxSize : 1);
            bulletCount = bulletMax;
        }

        public bool Shoot()
        {
            if (bulletCount > 0)
            {
                Console.WriteLine("Ratatata");
                --bulletCount;
                return true;
            }
            else
            {
                Console.WriteLine("No Ratatata(((");
                return false;
            }
        }

        public void Recharge()
        {
            Console.WriteLine("*Reload sound*");
            bulletCount = bulletMax;
        }

    }

}