
using System.Xml.Linq;

namespace Step_By_Step_Dungeon
{
    public class EndBlock : GameObject, ILocated, IHasCollision
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int CollisionDamage { get; set; }

        public EndBlock()
        {
            Name = "Portal";
            Description = "A magical door that will lead you out of this dungeon.";
            Texture = '@';
            Coloring = ConsoleColor.DarkBlue;
            X = 1; Y = 5;
            CollisionDamage = 0;
        }
        public EndBlock(string name, string description, char texture, ConsoleColor coloring, int x, int y, int collisionDamage) : base(name, description, texture, coloring)
        {
            Name = name;
            Description = description;
            Texture = texture;
            Coloring = coloring;
            X = x; Y = y;
            CollisionDamage = collisionDamage;
        }
    }
}
