
namespace Step_By_Step_Dungeon
{

    public class FloorBlock : GameObject
    {
        public FloorBlock()
        {
            Name = "Cobblestone";
            Description = "Beautifully laid out stones that you can walk on.";
            Texture = '.';
            Coloring = ConsoleColor.DarkGray;
        }
        public FloorBlock(string name, string description, char texture, ConsoleColor coloring) : base (name, description, texture, coloring)
        {
            Name = name;
            Description = description;
            Texture = texture;
            Coloring = coloring;
        }
    }
}
