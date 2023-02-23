/*internal class Plane
{
    private const int maxTakeOffWeight = 20;
    private readonly String? model = "Unknown";
    private double length;
    private double height;
    private double weight;
    private readonly int crew;
    private double maxSpeed;
    private double wingspan;
    private String? weapons;

    public Plane() { }
    public Plane(string? model)
    {
        if (model != null && model.Length >= 1)
        {
            this.model = model;
        }
    }

    public Plane(string? model, double length, double height, double weight)
    {
        if (model != null && model.Length >= 1)
        {
            this.model = model;
        }
        Length = length;
        Height = height;
        Weight = weight;
    }

    public Plane(string? model, double length, double height, double weight, int crew, double maxSpeed, double wingspan, string? weapons)
    {
        if (model != null && model.Length >= 1)
        {
            this.model = model;
        }
        Length = length;
        Height = height;
        Weight = weight;
        if (crew>=0)
        {
            this.crew = crew;  
        }
        MaxSpeed = maxSpeed;
        Wingspan = wingspan;
        Weapons = weapons;
    }


    public static int MaxTakeOffWeight => maxTakeOffWeight;
    public string? Model => model;
    public int Crew => crew;
    public double Length
    {
        get => length;
        set
        {
            if (value > 0)
            {
                length = value;
            }
        }
    }
    public double Height
    {
        get => height;
        set
        {
            if (value > 0)
            {
                height = value;
            }
        }
    }
    public double Weight
    {
        get => weight;
        set
        {
            if (value >= 4)
            {
                weight = value;
            }
        }
    }
    public double MaxSpeed 
    { 
        get => maxSpeed;
        set 
        {
            if (value > 0)
            {
                maxSpeed = value;
            }
        } 
    }
    public double Wingspan 
    { 
        get => wingspan;
        set 
        {
            if ( value >= 1)
            {
                wingspan = value;
            }
        }
    }
    public string? Weapons
    {
        get => weapons;
        set 
        {
            if (value != null && value.Length>=1)
            {
                weapons = value;
            }
        }
    }


    public void Fly() 
    {
        Console.WriteLine($"{model} took off");
    }
    public void ToLand()
    {
        Console.WriteLine($"{model} landed");
    }
    public void ToLoad(double value)
    {
        if ((value + weight) < maxTakeOffWeight)
        {
            weight += value;
        }
    }

}
class Task6
{
    static void Main()
    {
        Plane plane1 = new Plane();
        Plane plane2 = new Plane("Мрiя");
        Plane plane3 = new Plane("f-16", 15, 5, 9.2);
        Plane plane4 = new Plane("f-35", 15.5, 5.28, 12.2, 1, 1.6, 10, "AMRAAMS, AIM-120C");

        Console.WriteLine($"plane1 Weight - {plane1.Weight}");
        Console.WriteLine($"plane2 Weight - {plane2.Weight}");
        Console.WriteLine($"plane3 Weight - {plane3.Weight}");
        Console.WriteLine($"plane4 Weight - {plane4.Weight}\n");

        plane1.ToLoad(9.1);
        plane2.ToLoad(5.9);
        plane3.ToLoad(6.1);
        plane4.ToLoad(3.6);

        Console.WriteLine($"plane1 Weight - {plane1.Weight}");
        Console.WriteLine($"plane2 Weight - {plane2.Weight}");
        Console.WriteLine($"plane3 Weight - {plane3.Weight}");
        Console.WriteLine($"plane4 Weight - {plane4.Weight}\n");

        plane1.Fly();
        plane2.Fly();
        plane3.Fly();
        plane4.Fly();

        Console.WriteLine();

        plane1.ToLand();
        plane2.ToLand();
        plane3.ToLand();
        plane4.ToLand();
    }

}
*/