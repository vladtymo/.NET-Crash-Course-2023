//1
//Console.WriteLine("what a day today?");
//int day = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("what a month today?");
//int month = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("what a year today?");
//int year = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"Today {day}.{month}.{year}");




//2
//Console.WriteLine("Enter the height of the rectangle");
//float width = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter the width of the rectangle");
//float height = Convert.ToInt32(Console.ReadLine());

//float area = width * height;

//float perimeter = 2 * (width * height);

//Console.WriteLine($"Area is {area}, perimeter is {perimeter}");

//Console.ReadKey();



//3
//Console.WriteLine("Введіть радіус кола");

//int radius = Convert.ToInt32(Console.ReadLine());
//float area = 3.14f * (radius * radius);

//Console.WriteLine($"Area is {area}");

//Console.ReadKey();



//4
Console.WriteLine("Enter second: ");
int seconds = int.Parse(Console.ReadLine());

int hours = seconds / 3600;

seconds -= hours * 3600;
int minutes = seconds / 60;

seconds -= minutes * 60;

Console.WriteLine($"{hours}:{minutes}:{seconds}");
