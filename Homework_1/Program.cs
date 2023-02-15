//First question

//Console.WriteLine("Enter day: ");
//int day = int.Parse(Console.ReadLine());
//Console.WriteLine("Enter month: ");
//int month = int.Parse(Console.ReadLine());
//Console.WriteLine("Enter year: ");
//int year = int.Parse(Console.ReadLine());
//Console.WriteLine($"{day}/{month}/{year}\n");

//Second question

//float a = float.Parse(Console.ReadLine());
//float b = float.Parse(Console.ReadLine());
//float P,S;
//P = (a + b) * 2;
//Console.WriteLine(P);   
//S = a * b;  
//Console.WriteLine(S);

//Third question

//const float pi = 3.14F;
//float r = float.Parse(Console.ReadLine());
//float S;
//S=float.Pi*MathF.Pow(r,2);
//Console.WriteLine($"Area = {S}\n");

//Four question

//int totalSeconds=int.Parse(Console.ReadLine());
//int hours = totalSeconds / 3600;
//int minutes = (totalSeconds % 3600)/60;
//int seconds = totalSeconds % 60;
//Console.WriteLine("HH:MM:SS format:\n {0:00}:{1:00}:{2:00}",hours,minutes,seconds);

//Five question

int year = int.Parse(Console.ReadLine());
bool isLeap=DateTime.IsLeapYear(year);
int daysInYear = isLeap ? 366 : 365;
Console.WriteLine("There are {0} days in {1}",daysInYear,year);
