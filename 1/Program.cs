//------------------Task1------------------
Console.Write("Enter year: ");
int year =  int.Parse(Console.ReadLine());

Console.Write("Enter month: ");
int month =  int.Parse(Console.ReadLine());

Console.Write("Enter day: ");
int day =  int.Parse(Console.ReadLine());

Console.WriteLine($"{day}/{month}/{year}");
//------------------Task2------------------
Console.Write("Enter height of reactangle: ");
int height = int.Parse(Console.ReadLine());
Console.Write("Enter width of reactangle: ");
int width = int.Parse(Console.ReadLine());
Console.WriteLine($"Perimetr of reactangle: {2*(height+width)}");
Console.WriteLine($"Area of reactangle: {width*height}");
//------------------Task3------------------
Console.Write("Enter radius of circle: ");
int r = int.Parse(Console.ReadLine());
Console.WriteLine($"{r*r*Math.PI}");
//------------------Task4------------------
Console.Write("Enter seconds: ");
int seconds = int.Parse(Console.ReadLine());
int h = seconds/3600;
int m = (seconds % 3600) / 60; 
int s = (seconds % 3600) % 60;
Console.WriteLine($"Time: {h}H:{m}m:{s}s");
//------------------Task5------------------
Console.Write("Enter year: ");
int y =  int.Parse(Console.ReadLine());

if(y % 400 == 0 || (y % 4 == 0 && y % 100 != 0 )){
    Console.WriteLine($"366 days in {y} year");
}else{
    Console.WriteLine($"365 days in {y} year");
}