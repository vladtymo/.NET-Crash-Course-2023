using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swayze_task_2
{
    enum Action { Radius =1, Area, Perimetr};
    internal class Circle
    {
        public void Calculate_Circle()
        {
            Console.Write("Enter a diameter in circle:");
            double diameter = double.Parse(Console.ReadLine());

            Console.WriteLine("Select a action in this list:\n"
                +$"{(int)Action.Radius} - Calculate radius in circle.\n"
                +$"{(int)Action.Area} - Calculate area in cirlce.\n"
                +$"{(int)Action.Perimetr} - Calculate perimetr in circle.");
            Action select_action = (Action)Enum.Parse(typeof(Action), Console.ReadLine());

            switch (select_action)
            {
                case Action.Radius:
                    Console.WriteLine($"Radius in circle = {Math.Round(diameter / 2,2)}");
                    break;
                case Action.Area:
                    Console.WriteLine($"Area in circle = {Math.Round(Math.PI * diameter,2)}");
                    break;
                case Action.Perimetr:
                    Console.WriteLine($"Perimetr in circle = {Math.Round(Math.PI * diameter,2)}");
                    break;
                default:
                    Console.WriteLine("I dont see this number in list");
                    break;
            }
        }
    }
}
