
using System.Drawing;
using System.Dynamic;
using System.Numerics;
using Newtonsoft.Json;

namespace Step_By_Step_Dungeon
{
    public class LevelsScreen : Screen
    {
        public override void Load(ScreenLib screenLib)
        {
            base.Load(screenLib);
            screenLib.MakeBackup();
            Console.WriteLine();
            Console.WriteLine(Name);
            Console.WriteLine();

            int i;
            for (i = 0; i<screenLib.Game.Length; i++)
            {
                Console.SetCursorPosition(12, i+5);
                Console.WriteLine($"{DescriptionArray[0]} {i+1} {DescriptionArray[1]} {screenLib.Game[i].Name}");
            }
            Console.SetCursorPosition(12, i+5);
            Console.WriteLine(DescriptionArray[2]);

            Console.SetCursorPosition(0, SizeY);
            Console.WriteLine(new string('-', SizeX));

            Option(screenLib);
        }

        protected override void Option(ScreenLib screenLib)
        {
            ConsoleKey move = Console.ReadKey(true).Key;
            switch (move)
            {
                case ConsoleKey.D1:
                    if(screenLib.Game.Length > 0)
                    {
                        screenLib.Game[0].Load(screenLib);
                    }
                    else
                    {
                        Option(screenLib);
                    }
                    break;
                case ConsoleKey.D2:
                    if (screenLib.Game.Length > 1)
                    {
                        screenLib.Game[1].Load(screenLib);
                    }
                    else
                    {
                        Option(screenLib);
                    }
                    break;
                case ConsoleKey.D3:
                    if (screenLib.Game.Length > 2)
                    {
                        screenLib.Game[2].Load(screenLib);
                    }
                    else
                    {
                        Option(screenLib);
                    }
                    break;
                case ConsoleKey.D4:
                    if (screenLib.Game.Length > 3)
                    {
                        screenLib.Game[3].Load(screenLib);
                    }
                    else
                    {
                        Option(screenLib);
                    }
                    break;
                case ConsoleKey.D5:
                    if (screenLib.Game.Length > 4)
                    {
                        screenLib.Game[4].Load(screenLib);
                    }
                    else
                    {
                        Option(screenLib);
                    }
                    break;
                case ConsoleKey.D6:
                    if (screenLib.Game.Length > 5)
                    {
                        screenLib.Game[5].Load(screenLib);
                    }
                    else
                    {
                        Option(screenLib);
                    }
                    break;
                case ConsoleKey.D7:
                    if (screenLib.Game.Length > 6)
                    {
                        screenLib.Game[6].Load(screenLib);
                    }
                    else
                    {
                        Option(screenLib);
                    }
                    break;
                case ConsoleKey.D8:
                    if (screenLib.Game.Length > 7)
                    {
                        screenLib.Game[7].Load(screenLib);
                    }
                    else
                    {
                        Option(screenLib);
                    }
                    break;
                case ConsoleKey.D9:
                    if (screenLib.Game.Length > 8)
                    {
                        screenLib.Game[8].Load(screenLib);
                    }
                    else
                    {
                        Option(screenLib);
                    }
                    break;
                case ConsoleKey.Escape:
                    screenLib.Start.Load(screenLib);
                    break;
                default:
                    Option(screenLib);
                    break;
            }

        }

        public LevelsScreen()
        {
            SizeX = 60;
            SizeY = 20;
            Name = "-------------------------- LEVELS --------------------------";
            Description = "Press \"Esc\" to go to the main menu";
            DescriptionArray = new string[] {"Press", "to go to", Description};
        }
    }
}
