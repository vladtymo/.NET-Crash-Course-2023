internal class PC 
{
    private readonly string type;
    private readonly string brand;
    private int RAM;
    private string CPU;
    private string GPU;
    private string motherboardBrand;
    private int maxValueRAM;
    private string? HDD;
    private string? SSD;

    public PC() 
    {
        type = "Pc";
        brand = "Unknown";
        CPU= "Intel Pentium e625 2.5Ghz";
        GPU = "Intel HD graphicks 3000";
        RAM = 4;
        maxValueRAM= 8;
        motherboardBrand= "AS ROCK";
        HDD = "256 gb";
        SSD = "Empty";
    }
    public PC(string type, string brand, string cPU, string gPU, int rAM, int maxValueRAM, 
              string motherboardBrand, string hDD, string sSD)
    {
        this.type = type;
        if (type == "Laptop" || type == "Laptop") 
        {
        this.brand = brand;
        }
        if (RAM <= maxValueRAM) 
        {
        this.RAM = rAM;
        }
        this.maxValueRAM = maxValueRAM;
        this.CPU = cPU;
        this.GPU = gPU;
        this.motherboardBrand = motherboardBrand;
        this.HDD = hDD;
        this.SSD = sSD;
    }
    public void showInfo() 
    {
        if (type == "PC" || type == "pc" || type == "Pc") {
        Console.WriteLine($"Type: {type} \n" +
                          $"CPU: {CPU} \n" +
                          $"GPU: {GPU} \n" +
                          $"Ram: {RAM} \n" +
                          $"Max value RAM: {maxValueRAM} \n" +
                          $"Motherboar brand: {motherboardBrand} \n" +
                          $"HDD: {HDD} \n" +
                          $"SSD: {SSD} \n");
        }
        else {
            Console.WriteLine($"Type: {type} \n" +
                              $"Brand: {brand} \n" +
                              $"CPU: {CPU} \n" +
                              $"GPU: {GPU} \n" +
                              $"Ram: {RAM} \n" +
                              $"Max value RAM: {maxValueRAM}  \n" +
                              $"Motherboar brand: {motherboardBrand}  \n" +
                              $"HDD: {HDD}  \n" +
                              $"SSD: {SSD}  \n");
        }
    }
    public int getRam() 
    {
        return RAM;
    }
    public void setRam(int newRamValue) 
    {
        if (newRamValue <= maxValueRAM)
        {
        this.RAM = newRamValue;
        }
    }
    public void addRam()
    {
        Console.WriteLine("\nInput value of RAM:");
        int newValueRam = int.Parse(Console.ReadLine()!);
        newValueRam += RAM;
        if (newValueRam <= maxValueRAM)
        {
            setRam(newValueRam);
        }
        else Console.WriteLine("Motherboard does not support this value of RAM, remove back\n");
    }
    public void showRam() 
    {
        Console.WriteLine($"\nRAM: {RAM}");
    }
    public void setHDD(string newHDD) 
    {
        this.HDD = newHDD;
    }
    public string getHDD() 
    {
        return this.HDD;
    }
    public void newHDD() 
    {
        Console.WriteLine("Input a new HDD");
        string value=Console.ReadLine()!;
        setHDD(value);
    }
    public void setSSD(string newSSD)
    {
        this.SSD = newSSD;
    }
    public string getSSD()
    {
        return this.SSD;
    }
    public void newSSD() 
    {
        Console.WriteLine("Input a new SSD");
        string value =Console.ReadLine()!;
        setSSD(value);
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        PC Lenovo = new PC("Laptop","Lenovo","i5-11400H, 3.2-4.4GHz","RTX 3050 4gb",16,32,"ASUS","Empty","512 Gb");
        Lenovo.showInfo();
        PC newPc = new PC("PC","--","i7-10770H, 3.6GHz","Gigabyte GTX 1650 6gb",8,64,"Gigabyte","512","512");
        newPc.showInfo();
        Lenovo.addRam();
        Lenovo.showInfo();
        Lenovo.newHDD();
        Lenovo.newSSD();
        Lenovo.showInfo();
        PC def = new PC();
        def.showInfo();
    }
}
