
using System.Diagnostics;
using System.Globalization;

namespace Step_By_Step_Dungeon
{
    public class StartScreen : Screen
    {
        public override void Load(ScreenLib screenLib)
        {
            base.Load(screenLib);
            Console.WriteLine();
            Console.WriteLine(Name);
            Console.WriteLine();

            int j = 0;
            foreach (string i in DescriptionArray)
            {
                Console.SetCursorPosition((SizeX - i.Length) / 2, 5+j);
                Console.WriteLine(i);
                j += 2;
            }
            Console.SetCursorPosition(0, SizeY);
            Console.WriteLine(new string('-', SizeX));

            Option(screenLib);
        }

        protected override void Option(ScreenLib screenLib)
        {
            ConsoleKey move = Console.ReadKey(true).Key;
            switch (move)
            {
                case ConsoleKey.M:
                    screenLib.Manual.Load(screenLib);
                    break;
                case ConsoleKey.L:
                    screenLib.Levels.Load(screenLib);
                    break;
                default:
                    Option(screenLib);
                    break;
            }
        }

        public StartScreen()
        {
            SizeX = 60;
            SizeY = 20;
            Name = "------------------- Step-by-step Dungeon -------------------";
            Description = "Press \"L\" to go to the level selection";
            DescriptionArray = new string[] { Description, "Press \"M\" to go to the manual" };
        }

    }
}
