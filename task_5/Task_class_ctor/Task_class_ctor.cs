
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;

class Plane
{
    private readonly string name;
    private readonly string brand;
    private const int maxHeight=11000;//м
    private int heightNow=0;
    private const int maxSpeed=850;//км\год
    private int speedNow=0;
    public string getName { get { return this.name; } }
    public string getBrand { get { return this.brand; } }
    public int getHeightNow { get { return this.heightNow; } }
    public int getSpeedNow { get { return this.speedNow; } }
    static bool IsValidHeight(int heightNow)
    {
       if(heightNow < maxHeight && heightNow >= 0)return true;
       return false;
    }
    static bool IsValidSpeed(int speedNow)
    {
        if (speedNow < maxSpeed && speedNow >= 0)return true;
        return false;
    }
    public Plane()
    {
        this.name = "Noname";
        this.brand = "Nobrend";
        this.heightNow = 0;
        this.speedNow = 0;
    }
    public Plane(string name,string brand)
    {
        this.name = name;
        this.brand = brand;
        this.heightNow = 0;
        this.speedNow = 0;
    }
    public Plane(string name, string brand, int heightNow, int speedNow)
    {
        this.name = name;
        this.brand = brand;
        if(IsValidHeight(heightNow))this.heightNow = heightNow;
        if(IsValidSpeed(speedNow))this.speedNow = speedNow;
    }
    public void Print()
    {
        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
        Console.WriteLine($"Name: {this.name}");
        Console.WriteLine($"Brand: {this.brand}");
        Console.WriteLine($"HeightNow: {this.heightNow} m");
        Console.WriteLine($"SpeedNow: {this.speedNow} km\\h");
        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
    }
    public void ShowLimites()
    {
        Console.WriteLine("********************************");
        Console.WriteLine($"Limit height {maxHeight} m");
        Console.WriteLine($"Limit speed {maxSpeed} km\\h");
        Console.WriteLine("********************************");
    }
    public void Setup(int heightNow,int speedNow)
    {
        if (IsValidHeight(heightNow)&&IsValidSpeed(speedNow))
        {
            this.heightNow = heightNow;
            this.speedNow = speedNow;
            Console.WriteLine($"Height to {heightNow} and speed to {speedNow} changed");
        } else Console.WriteLine("Height and speed not changed, invalid value");
        Console.WriteLine("----------------------------------");
    }
    public void SetHeight(int heightNow)
    {
        if (IsValidHeight(heightNow))
        {
            this.heightNow = heightNow;
            Console.WriteLine($"Height changed to {heightNow}");
        }else Console.WriteLine("Height not changed, invalid value");
        Console.WriteLine("----------------------------------");
    }
    public void SetSpeed(int speedNow)
    {
        if (IsValidSpeed(speedNow))
        {
            this.speedNow = speedNow;
            Console.WriteLine($"Speed changed to {speedNow}");
        } else Console.WriteLine("Speed not changed, invalid value");
        Console.WriteLine("----------------------------------");
    }

}

namespace Task_class_ctor
{
    internal class Task_class_ctor
    {
        static void Main(string[] args)
        {
         Plane plane = new Plane();
            plane.Print();
            Plane plane1 = new Plane("Mriya","An-225",9000,400);
            plane1.Print();
            plane1.SetHeight(1000);
            plane1.SetSpeed(300);
            Console.WriteLine($"Height: {plane1.getHeightNow}");
            Console.WriteLine($"Speed: {plane1.getSpeedNow}");
            plane1.Print();
            Plane plane2 = new Plane("Ruslan", "An-124");
            Console.WriteLine($"Name: {plane2.getName}\nBrand: {plane2}");
            plane2.Print();
            plane2.Setup(4000, 450);
            plane2.Print();

        }
    }
}