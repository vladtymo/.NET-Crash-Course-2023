
class Weapon
{
    int range;
    float caliber;
    int patronInMagaz;
    int maxSizeMagaz;
    public void Initialize(int range, float caliber, int maxSizeMagaz)
    {
        this.range = range;
        this.caliber = caliber;
        this.maxSizeMagaz = maxSizeMagaz;
    }
    public bool Shot()
    {
        if (this.patronInMagaz == 0) { Console.WriteLine("Shot did not happen, reload the magazine"); return false; }
        else { Console.WriteLine("Shot"); this.patronInMagaz -= 1; return true; }
    }
    public void Recharge()
    {
        Console.WriteLine($"Before reloading: {this.patronInMagaz}");
        if(this.patronInMagaz < this.maxSizeMagaz)this.patronInMagaz=this.maxSizeMagaz;else Console.WriteLine("MaxSize Magazin");
        Console.WriteLine($"After reloading: {this.patronInMagaz}");
    }
    public async void Save()
    {
        string[] setup =
        {
            this.range.ToString(),this.caliber.ToString(),this.patronInMagaz.ToString() ,this.maxSizeMagaz.ToString()+"\n"
        };
        await File.WriteAllLinesAsync("write.txt", setup);
    }
    public void Load()
    {
        string[] setup = System.IO.File.ReadAllLines(@".\write.txt");
        this.range = int.Parse(setup[0]);
        this.caliber = float.Parse(setup[1]);
        this.patronInMagaz = int.Parse(setup[2]);
        this.maxSizeMagaz = int.Parse(setup[3]);
    }
    public void Print()
    {
        Console.WriteLine(this.range.ToString() + " m \n"
        +this.caliber.ToString() + " mm \n"
        +this.patronInMagaz.ToString() + " ammo\n"
        +this.maxSizeMagaz.ToString() + " ammo\n");
    }
}
internal class Task_OOP_weapons
{
    private static void Main(string[] args)
    {
     Weapon pistol=new Weapon();
        pistol.Initialize(100, 9.0F, 15);
        pistol.Print();
        pistol.Recharge();
        pistol.Shot();
        pistol.Save();
        pistol.Print();
        Weapon copygun = new Weapon();
        copygun.Load();
        copygun.Print();
        copygun.Recharge();
        copygun.Shot();
        copygun.Print();
    }
}