Console.WriteLine("Enter value seconds");
int valueSeconds = int.Parse(Console.ReadLine());
const int TimeMax = 60;
const int HoursMax = 24;
int seconds = valueSeconds % TimeMax;
int minutes = (valueSeconds / TimeMax)%TimeMax;
int hours = ((valueSeconds/TimeMax)/TimeMax)%HoursMax ;
int days = ((valueSeconds / TimeMax)/TimeMax)/HoursMax;
Console.WriteLine($"days:{days} | {hours}:{minutes}:{seconds}");