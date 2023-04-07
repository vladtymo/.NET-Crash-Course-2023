
namespace Step_By_Step_Dungeon
{
    public abstract class Screen : INameable
    {
        public string[] DescriptionArray;
        public int SizeX { get; set; }
        public int SizeY { get; set; }
        public string Name { get ; set; }
        public string Description { get; set; }

        public virtual void Load(ScreenLib screenLib)
        {
            Console.Clear();
            Console.CursorVisible = false;
            Console.SetWindowSize(SizeX, SizeY + 5);
            Console.SetCursorPosition(0, 0);
        }

        protected abstract void Option(ScreenLib screenLib);

        public Screen()
        {
            SizeX = 60;
            SizeY = 20;
            Name = "Name";
            Description = "Description";
        }

    }
}
