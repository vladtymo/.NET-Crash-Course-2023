
internal class Program
{
    private static void Main(string[] args)
    {

        /*
        ElectroGuitar eg1 = new ElectroGuitar("Gibson", 4);
        eg1.ShowShortInfo();
        ElectroGuitar eg2 = new ElectroGuitar("Gibson", "Oak", 7, 1, 20);
        eg2.ShowInfo();
        eg2.SetFretsNumber(29);
        eg2.SetStringsNumber(12);
        eg2.SetMaterial("Black Oak");
        eg2.ShowInfo();*/

        ElectroGuitar[] eg = new ElectroGuitar[3];
        eg[0] = new ElectroGuitar("Gibson", 7);
        eg[1] = new ElectroGuitar("Yamaha", 4, "Pine", 0, 26);
        eg[2] = new ElectroGuitar("Fender", 9, "Redwood", 4, 24);
      
        eg[0].ShowShortInfo();
        eg[1].ShowShortInfo();
        eg[2].ShowInfo();
        eg[2].SetFretsNumber(29);
        eg[2].SetStringsNumber(12);
        eg[2].SetMaterial("Black Oak");
        eg[2].ShowInfo();
    }
}
class ElectroGuitar
{
    private const int MinStringNumber = 6;
    private int StringsNumber;
    private const int MinFretsCount = 22;
    private int FretsCount;
    private int? UsedTime;
    private string Material;
    private readonly string GuitarName;
    
    public void SetStringsNumber(int SelectedStringNumber)
    {
        if (SelectedStringNumber <= MinStringNumber)
            this.StringsNumber = MinStringNumber;
        else if (SelectedStringNumber > MinStringNumber)
            this.StringsNumber = SelectedStringNumber;
    }
    public void SetFretsNumber(int f)
    {
        if (f <= MinFretsCount)
            this.FretsCount = MinFretsCount;
        else if (f > MinFretsCount)
            this.FretsCount = f;
    }
    public void SetMaterial(string ss)
    {
        this.Material = ss;
    }
    public void ShowShortInfo()
    {
        Console.WriteLine($"Guitar: {GuitarName} {StringsNumber}");
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Guitar: {GuitarName} {StringsNumber}. It's made with {Material}, it has {FretsCount} frets, it was used for {UsedTime} years");
    }
  
    public ElectroGuitar()
    {
        
    }
    public ElectroGuitar(string GuitarName, int StringsNumber)
    {
        this.StringsNumber=StringsNumber;
        this.GuitarName = GuitarName;
    }
    public ElectroGuitar(string GuitarName, int StringsNumber, string Material, int UsedTime, int FretsCount)
    {
        this.FretsCount = MinFretsCount;
        this.StringsNumber = StringsNumber;
        this.GuitarName = GuitarName;
        this.Material = Material;
        this.UsedTime = UsedTime;
    }
}