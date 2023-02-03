using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swayze_task_2
{
    enum Tasks { Week_number=1, convert_walley=2, diameter_circle=3, check_palidrom=4};
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Which task you need to do?\n" +
                    $"{(int)Tasks.Week_number} - You write a number in week, i say what is this day.\n"
                    +$"{(int)Tasks.convert_walley} - You write money in UAH, i convert him to another wallet.\n"
                    +$"{(int)Tasks.diameter_circle} - You write a diameter in circle, i write area/perimetr/radius.\n"
                    +$"{(int)Tasks.check_palidrom} - You write number, i check palidrom is him.");
                Tasks task = (Tasks)Enum.Parse(typeof(Tasks), Console.ReadLine());
                
                Console.WriteLine();

                switch (task)
                {
                    case Tasks.Week_number:
                        Week check = new Week();
                        check.Weeks();
                        break;
                    case Tasks.convert_walley:
                        Convertmoney convertation = new Convertmoney();
                        convertation.Convert();
                        break;
                    case Tasks.diameter_circle:
                        Circle checkcircle = new Circle();
                        checkcircle.Calculate_Circle();
                        break;
                    case Tasks.check_palidrom:
                        Palindrom checkpalindrom = new Palindrom();
                        checkpalindrom.comparasion();
                        break;
                    default:
                        Console.WriteLine("I dont see this number in list.");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}
