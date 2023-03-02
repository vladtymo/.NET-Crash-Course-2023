using System.Runtime.InteropServices;

namespace crash_course_OOP_inharitance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sparrowhawk sparrowhawk = new Sparrowhawk("Madagascariensis", 12, 20, "Subtropical forest", "Grey", "Hunter", "Accipitriformes", true, "Madagascarian sparrowhwak");
            Turtle turtle = new Turtle("Orbicularis", 1, 33, "Marsh terrain", "Testudines", "Emydidae", "European pond turtle");
            Perch perch = new Perch("Fluviatilis", 20, 1, "Slow-flowing rivers", "Actinopterygii", "Little", "Perciformes", "European perch");

            sparrowhawk.MakeSound();
            turtle.MakeSound();
            perch.MakeSound();

            perch.ShowInfo();
            turtle.ShowInfo();
            sparrowhawk.ShowInfo();
            
        }
    }
}