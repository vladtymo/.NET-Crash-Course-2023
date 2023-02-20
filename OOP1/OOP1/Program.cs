class Weapon
{
    int range;
    double caliber;
    int MagazineSize;
    int CurentBulletsInMagazine;

   public void Initialize(int r, double c, int Mag)
    {
        range = r;
        caliber = c;
        MagazineSize = Mag;
    }
    public void Show()
    {
        Console.WriteLine($"Range: {range}\n"
           + $"Caleber: {caliber}\n"
           + $"Magazine Size: {MagazineSize}\n"
           + $"Current Bullets In Magazine: {CurentBulletsInMagazine}");
    }
    public void Reload()
    {
        Console.WriteLine("Weapon was reloaded!");
        CurentBulletsInMagazine = MagazineSize;
    }
    public void Shot()
    {
        if (CurentBulletsInMagazine != 0)
        {
            CurentBulletsInMagazine--;
            Console.WriteLine($"Weapon Shooted! Bullets left: {CurentBulletsInMagazine}");
        }
        else
            Console.WriteLine("Not enough bullets in magazine! Reload the weapon!");
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        string s;
            Weapon show = new Weapon();
            show.Initialize(1000, 7.62, 30);
            show.Show();
        do
        {
            Console.WriteLine("Що бажаєте зробити?\n"+"1 - reload\n"+"2 - shoot\n"+"3 - check info\n"+"4 - exit\n");
            s = Console.ReadLine();
            switch (s)
                {
                case "1": show.Reload();
                    break;
                case "2": show.Shot();
                    break;
                case"3": show.Show();
                    break;
                case "4": s = "Exit";
                    break;
                default: Console.WriteLine("Такої операції немає!");
                    break;
            }
        } while (s != "Exit");
    }
}