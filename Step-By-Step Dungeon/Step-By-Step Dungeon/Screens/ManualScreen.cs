
namespace Step_By_Step_Dungeon
{
    public class ManualScreen : Screen
    {
        public override void Load(ScreenLib screenLib)
        {

            base.Load(screenLib);
            Console.WriteLine("------------------MANUAL------------------");
            Console.WriteLine("INFO1");
            Console.WriteLine("INFO2");
            Console.WriteLine("INFO3");
            Console.WriteLine("Press Esc to Exit");
            Option(screenLib);
        }

        protected override void Option(ScreenLib screenLib)
        {
            ConsoleKey move = Console.ReadKey(true).Key;
            if (move == ConsoleKey.Escape)
            {
                screenLib.Start.Load(screenLib);
            }
            else
            {
                Option(screenLib);
            }

        }

    }
}
