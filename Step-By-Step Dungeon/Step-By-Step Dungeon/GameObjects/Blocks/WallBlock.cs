
namespace Step_By_Step_Dungeon
{

    public class WallBlock : GameObject, IHasCollision
    {
        public int CollisionDamage { get; set; }

        public WallBlock()
        {
            Name = "Stone";
            Description = "A massive rock that forms the walls.";
            Texture = '#';
            Coloring = ConsoleColor.Gray;
            CollisionDamage = 0;
        }

        public WallBlock(string name, string description, char texture, ConsoleColor coloring, int collisionDamage) : base(name, description, texture, coloring)
        {
            Name = name;
            Description = description;
            Texture = texture;
            Coloring = coloring;
            CollisionDamage = collisionDamage;
        }
    }
}
