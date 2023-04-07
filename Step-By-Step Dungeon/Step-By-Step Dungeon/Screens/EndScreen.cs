
using System.Reflection.Emit;

namespace Step_By_Step_Dungeon
{
    public class EndScreen : Screen
    {
        public bool Success { get; set; }
        public override void Load(ScreenLib screenLib)
        {
            base.Load(screenLib);

            Console.WriteLine();
            Console.WriteLine(Name);
            Console.WriteLine();
            Console.SetCursorPosition(20, 5);
            if (Success)
            {
                
                Console.WriteLine("Success!!!");
            }
            else
            {
                Console.WriteLine("Fail!!!");
            }

            Console.SetCursorPosition(20, 7);
            Console.WriteLine("Press Esc to Exit");

            Console.SetCursorPosition(0, SizeY);
            Console.WriteLine(new string('-', SizeX));

            screenLib.LoadBackup();
            Option(screenLib);
        }

        protected override void Option(ScreenLib screenLib)
        {           
            ConsoleKey move = Console.ReadKey(true).Key;
            switch (move)
            {
                case ConsoleKey.Escape:
                    screenLib.Start.Load(screenLib);
                    break;
                case ConsoleKey.L:
                    screenLib.Levels.Load(screenLib);
                    break;
                default:
                    Option(screenLib);
                    break;
            }

        }

        public EndScreen()
        {
            SizeX = 60;
            SizeY = 20;
            Name = "--------------------- Level Completed ----------------------";
            Description = "Press \"Esc\" to go to the main menu";
            //DescriptionArray = new string[] { "Press", "to go to", Description };
        }

    }
}
