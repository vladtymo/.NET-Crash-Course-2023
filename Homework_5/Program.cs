using System.Reflection;
internal class Weapon
{

    private float calibr;
    private int shotDistance;
    private int magazineSize;
    private int ammo;

    public void Initializer(float cal, int shotDis, int magSize, int a)
    {
        calibr = cal;
        shotDistance = shotDis;
        magazineSize = magSize;
        ammo = a;
    }
    //default ctor
    //public Weapon()
    //{
    //    calibr = 5.45F;
    //    shotDistance = 1200;
    //    magazineSize = 30;
    //    ammo = 30;
    //}

    //public Weapon(float calibr, int shotDistance, int magazineSize, int ammo)
    //{
    //    this.calibr = calibr;
    //    if (shotDistance < 3500)
    //    {
    //        this.shotDistance = shotDistance;
    //    }
    //    else Console.WriteLine("Error value(shotDistance)");
    //    this.magazineSize = magazineSize;
    //    if (ammo <= magazineSize)
    //    {
    //        this.ammo = ammo;
    //    }
    //    else Console.WriteLine("MagazineSize<Ammo");
    //}
    public void printInfo()
    {
        Console.WriteLine($"Calibr: {calibr} | Range: {shotDistance} | Magazine capacity: {magazineSize} | Bullets on magazine: {ammo} ");
    }
    public bool Shot()
    {
        if (ammo == 0)
        {
            Console.WriteLine("*Click*\nAmmo is empty, need reload");
            return false;
        }
        else
        {
            Console.WriteLine("Piu");
            --ammo;
            return true;
        }
    }
    public void Reload()
    {
        Console.WriteLine($"Ammo before reload: {ammo}");
        ammo = magazineSize;
        Console.WriteLine($"Ammo after reload: {ammo}");
    }
    //public void Shot()
    //{
    //    if (ammo > 0)
    //    {
    //        Console.WriteLine("Piu");
    //        --ammo;
    //    }
    //    else Console.WriteLine("*Click*\n Ammo is empty, need reload");
    //}
}
    internal class Program
{
    private static void Main(string[] args)
    {
        //(First calibr->shotDistance->magazineCapacity->ammo)
        Weapon ak74 = new Weapon();
        ak74.Initializer(5.45F, 1200, 30, 30);
        ak74.printInfo();
        Weapon m4a1 = new Weapon();
        m4a1.Initializer(5.56F, 1600, 32, 15);
        m4a1.printInfo();
        for (int i = 0; i <= 30; ++i) {
            m4a1.Shot();
        }
        m4a1.printInfo();
        m4a1.Reload();
    }
}
