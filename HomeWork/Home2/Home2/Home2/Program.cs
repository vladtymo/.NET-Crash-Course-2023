//1. Показати лінію на екран.
//Символ та довжину лінії повинен вводити користувач.

using System.Security.Cryptography;

Console.WriteLine("Введiть символ з якого складатиметься лiнiя");
char Symbol = char.Parse(Console.ReadLine());
Console.WriteLine("Введiть довжину лiнiї");
int CountSymbol = int.Parse(Console.ReadLine());
for(int i=0;i<CountSymbol; ++i)
{
    Console.Write($"{Symbol}");
}


