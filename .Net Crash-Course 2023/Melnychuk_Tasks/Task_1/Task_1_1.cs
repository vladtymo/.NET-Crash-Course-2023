
/// <Task>
Console.ForegroundColor = ConsoleColor.Red;
Console.Title = "Task 1 ";
Console.WriteLine("\n\n\n\t\t\tПочаток введення дати");

Console.Write("\tВведіть день: ");
    int day = int.Parse(Console.ReadLine());
Console.Write("\tВведіть місяць: ");
    int mouth = int.Parse(Console.ReadLine());
Console.Write("\tВведіть рік: ");
    int year = int.Parse(Console.ReadLine());


Console.WriteLine($"\n\n\t{day}/{mouth}/{year}");


/// <Task>


Console.WriteLine("\n\n\t\t\t Вирахування площі та переметру");

Console.Write("First side: " );
int f_side=int.Parse(Console.ReadLine());
Console.Write("Second side: ");
int s_side = int.Parse(Console.ReadLine());

Console.WriteLine($"perimeter = {f_side * 2 + s_side * 2} | square = {f_side * s_side}");


/// <Task>


Console.WriteLine("\n\n\t\t\tВирахування площі кола");

Console.Write("Radius: ");
int radius = int.Parse(Console.ReadLine());

Console.WriteLine($"Площа = {Math.PI * radius*radius}");

/// <Task>


Console.Write("Введіть кількість секунд : ");
int second_count = int.Parse(Console.ReadLine());

int hours = second_count / 3600;
second_count -= hours * 3600;
int minutes = second_count / 60;
second_count -= minutes * 60;
int seconds = second_count;

Console.WriteLine($"{hours}/{minutes}/{seconds}");


Console.Write("Введіть рік");

double year_v = double.Parse(Console.ReadLine());

if (year_v % 4 == 0)
{
    if (year_v % 100 != 0 || (year_v % 100 == 0 && year_v % 400 == 0))
    {
        Console.WriteLine("Рік має 366 днів");
    }
}
else { Console.WriteLine(" Рік має 365 днів"); }




Console.ReadKey();

