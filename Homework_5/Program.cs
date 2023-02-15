class Weapon
{
    int range;
    float caliber;
    int countOfAmmo;
    int maxSize;

    public void Initialize(int r, float c, int s)
    {
        range = r;
        caliber = c;
        maxSize = s;
        countOfAmmo = maxSize;
    }

    public bool Shot()
    {

        if (countOfAmmo > 0)
        {
            countOfAmmo -= 1;
            if (countOfAmmo == 0)
            {
                Console.WriteLine($"BOOM!!!\t Now you have {countOfAmmo} bullets to shoot.\t Please reload magazine!\n");
            }
            else Console.WriteLine($"BOOM!!!\t Now you have {countOfAmmo} bullets to shoot\n");
            return true;
        }
        else
        {
            Console.WriteLine("You can't shoot, bacause of empty magazine. Please reload!\n");
            return false;
        }
    }

    public void Recharge()
    {
        if (countOfAmmo == 0)
        {
            countOfAmmo = maxSize;
            Console.WriteLine($"Reload comleted. Now u have {countOfAmmo} to shoot\n");
        }
        else Console.WriteLine($"You have {countOfAmmo} bullet in your magazine, you can't reload now!\n");
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        Weapon rifle = new Weapon();
        rifle.Initialize(1000, (float)5.56, 5);
        rifle.Shot();
        rifle.Shot();
        rifle.Recharge();
        rifle.Shot();
        rifle.Shot();
        rifle.Shot();
        rifle.Recharge();

        Weapon pistol = new Weapon();
        pistol.Initialize(500, (float)9, 5);
        pistol.Shot();
        pistol.Recharge();

    }
}