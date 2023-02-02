using System;

enum Area { perimeter=1, area=2 , radius=3  };
internal class Program
{

    private static void Main(string[] args)
    {
        Console.WriteLine("Введiть оперерацiю яку потрiбно виконати\n" +
"1)perimeter\n" +
"2)area\n" +
"3)radius");

        Area CoolOperation = Enum.Parse<Area>(Console.ReadLine());
        Console.WriteLine("Введiть дiаметр:");
        double diameter = Convert.ToDouble(Console.ReadLine());
        switch (CoolOperation) {
            case Area.radius:
                Console.WriteLine($"Радiус кола дорiвнює {diameter/2}");
                break;
            case Area.perimeter:
                Console.WriteLine($"Периметр кола дорiвнює {2*Math.PI*(diameter / 2)}");
                break;
            case Area.area:
                Console.WriteLine($"Площа кола дорiвнює {Math.PI*(diameter/2)*2}");
                break;
            default: Console.WriteLine("Введено не вiрне значення");
                break;
        }
    }
        

}