Console.WriteLine("Enter year: ");
int year= int.Parse(Console.ReadLine());
if ((year % 4) == 0|| (year % 400) == 0)
{
    Console.WriteLine("366");
}
else Console.WriteLine("365");
