
namespace Step_By_Step_Dungeon
{
    [Serializable]
    public abstract class GameObject : INameable
    {
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }

        public virtual char Texture { get; set; }
        public virtual ConsoleColor Coloring { get; set; }
        
        public char Visualize()
        {
            Console.ForegroundColor = this.Coloring;
            return Texture;
        }

        public GameObject()
        {
        }

        public GameObject(string name, string description, char texture, ConsoleColor coloring)
        {
            Name = name;
            Description = description;
            Texture = texture;
            Coloring = coloring;
        }
    }
}
