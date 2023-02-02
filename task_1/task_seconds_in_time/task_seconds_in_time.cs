Console.WriteLine("Enter value seconds");
int valueSeconds = int.Parse(Console.ReadLine());
int seconds = valueSeconds % 60;
int minutes = (valueSeconds / 60)%60;
int hours = (valueSeconds / 60)/60;
int days = ((valueSeconds / 60)/60)/60;
Console.WriteLine($"days: {days} {hours}:{minutes}:{seconds}");