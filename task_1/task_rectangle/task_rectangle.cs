Console.WriteLine("Enter a: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Enter b: ");
int b = int.Parse(Console.ReadLine());
if (a>0&&b>0)
{
int perimeter = (a + b)*2;
Console.WriteLine($"P = {perimeter}");
int area = a * b;
Console.WriteLine($"S = {area}");
}
else Console.WriteLine("Invalid value a or b");

