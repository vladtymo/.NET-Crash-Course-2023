// See https://aka.ms/new-console-template for more information

using hometask1.CalcPropFigures;
using hometask1.TimeDate;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

Figures FiguresWork1 = new Figures();
Clock ClockWork1 = new Clock();
/*
 * Перетворювач дати з dd.MM.YYYY в dd/MM/YYYY
 * ClockWork1.DateFunctionNow();
*/
/*
 * Обрахування площі та переметру прямокутника
 * FiguresWork1.Square();
*/

/*
 * Обрахування площі кола
 * FiguresWork1.Circle();
*/

/* Секунди в години-хвилини-секунди
 * ClockWork1.SecondsToTime();
*/

/* Скільки днів в році
 * ClockWork1.PrintYearDays();
*/

do
{


    try
    {
        Console.WriteLine("Будь-ласка зробiть свiй вибiр:\n" +
"1) Перетворювач дати з dd.MM.YYYY в dd/MM/YYYY\n" +
"2) Обрахування площi та переметру прямокутника\n" +
"3) Обрахування площi кола\n" +
"4) Конвертацiя Секунд в години:хвилини:секунди\n" +
"5) Скiльки днiв в роцi\n" +
"0) Завершити роботу програми");
        int zadanie = int.Parse(Console.ReadLine());

        if (zadanie == 1)
            ClockWork1.DateFunctionNow();
        else if (zadanie == 2)
            FiguresWork1.Square();
        else if (zadanie == 3)
            FiguresWork1.Circle();
        else if (zadanie == 4)
            ClockWork1.SecondsToTime();
        else if (zadanie == 5)
            ClockWork1.PrintYearDays();
        else if (zadanie == 0)
        {
            Process.GetCurrentProcess().Kill();
            break;
        }  
        continue;
    }
    catch (FormatException)
    {
        Console.WriteLine($"Введено не правильне значення ");
        continue;
    }
} while (true);


