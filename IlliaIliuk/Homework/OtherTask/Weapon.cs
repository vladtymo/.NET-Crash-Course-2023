/*
internal class Weapon
{
    private int maxSize;
    private int currentBullets;
    private int shotRange;
    private double caliber;

    public void Initialize(int shotRange = 1, double caliber = 9, int maxSize = 1)
    {
        if (shotRange > 0)
        {
            this.shotRange = shotRange;
        }
        if (maxSize > 0)
        {
            this.maxSize = maxSize;
        }
        this.caliber = caliber;
        this.currentBullets = maxSize;
    }
    public int GetMaxSize => maxSize; 
    public int GetCurrentBullets => currentBullets;
    public int GetShotRange => shotRange; 
    public double GetCaliber => caliber; 


    public bool Shot()
    {
        if (currentBullets>=1)
        {
            currentBullets--;
            return true;
        }
        return false;
    }

    public void Recharge() 
    {
        currentBullets = maxSize;
    }
}

class Task5
{
    static void Main()
    {
        Weapon weapon1 = new Weapon();
        weapon1.Initialize(100, 45, 6);
        Weapon weapon2 = new Weapon();
        weapon2.Initialize(1000, 7.62, 1);
        Weapon weapon3 = new Weapon();
        weapon3.Initialize(500, 5.56, 30);

        Console.WriteLine($"weapon1 CurrentBullets - {weapon1.GetCurrentBullets}");
        Console.WriteLine($"weapon2 CurrentBullets - {weapon2.GetCurrentBullets}");
        Console.WriteLine($"weapon3 CurrentBullets - {weapon3.GetCurrentBullets}\n");

        Console.WriteLine($"weapon1 shot - {weapon1.Shot()}");
        Console.WriteLine($"weapon2 shot - {weapon2.Shot()}");
        Console.WriteLine($"weapon3 shot - {weapon3.Shot()}\n");


        Console.WriteLine($"weapon1 CurrentBullets - {weapon1.GetCurrentBullets}");
        Console.WriteLine($"weapon2 CurrentBullets - {weapon2.GetCurrentBullets}");
        Console.WriteLine($"weapon3 CurrentBullets - {weapon3.GetCurrentBullets}\n");

        Console.WriteLine($"weapon1 shot - {weapon1.Shot()}");
        Console.WriteLine($"weapon2 shot - {weapon2.Shot()}");
        Console.WriteLine($"weapon3 shot - {weapon3.Shot()}\n");
    }

}
*/