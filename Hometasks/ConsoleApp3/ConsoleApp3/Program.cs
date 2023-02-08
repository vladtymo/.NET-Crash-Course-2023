using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    enum Task { Lines = 1, Guess = 2, Arrays = 3, Actioninarray = 4 };
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine($"Select task: \n"
                    + $"{(int)Task.Lines} - Task number 1\n"
                    + $"{(int)Task.Guess} - Task number 2\n"
                    + $"{(int)Task.Arrays} - Task number 3\n" +
                    $"{(int)Task.Actioninarray} - Task number 4");
                Task number = (Task)Enum.Parse(typeof(Task), Console.ReadLine());

                switch (number)
                {
                    case Task.Lines:
                        Line line = new Line();
                        line.Lines();
                        break;
                    case Task.Guess:
                        Randomdigit digit = new Randomdigit();
                        digit.randvalue();
                        break;
                    case Task.Arrays:
                        Arrays arr = new Arrays();
                        arr.Randomarray(); break;
                    case Task.Actioninarray:
                        Arraywithmenu arrs = new Arraywithmenu();
                        arrs.arrays();
                        break;
                }
            }

        }
    }
}
