Console.WriteLine("Enter year: ");
int year = int.Parse(Console.ReadLine());
Console.WriteLine("Enter month: ");
int month = int.Parse(Console.ReadLine());
Console.WriteLine("Enter day: ");
int day = int.Parse(Console.ReadLine());
if ((day<31&&day>0)&& (month <= 12 && month > 0))
{
    Console.WriteLine($"{day}/{month}/{year}");
}
else Console.WriteLine($"Invalid date: {day}/{month}/{year}");
