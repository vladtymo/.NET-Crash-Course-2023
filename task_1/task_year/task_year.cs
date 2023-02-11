Console.WriteLine("Enter year: ");
int year= int.Parse(Console.ReadLine());
if ((year % 4 == 0&&year%100!=0)||(year%100==0&&year%400==0))
{
    Console.WriteLine("Days: 366");
}
else Console.WriteLine("Days: 365");
