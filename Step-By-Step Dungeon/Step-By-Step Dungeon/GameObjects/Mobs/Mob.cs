
using Newtonsoft.Json;

namespace Step_By_Step_Dungeon
{
    // Не абстрактний тому що особливості серіалізатора
    public class Mob : GameObject, ICanBeDestroyed, IHasCollision, IMovable, ICloneable
    {
        public virtual int HealthPoint { get; set; }
        public virtual bool isDestroyed { get; set; }
        public virtual int CollisionDamage { get; set; }
        public virtual int X { get; set; }
        public virtual int Y { get; set; }



        public virtual void HealthUpdate()
        {
        }

        public virtual void Move(GameObject[,] FieldOfVision)
        {
        }

        public virtual object Clone()
        {
            string json = JsonConvert.SerializeObject(this);
            return JsonConvert.DeserializeObject<object>(json);
        }

        public Mob(string name, string description, char texture, ConsoleColor coloring, int healthPoint, int collisionDamage, int x, int y) : base(name, description, texture, coloring)
        {
            Name = name;
            Description = description;
            Texture = texture;
            Coloring = coloring;

            HealthPoint = healthPoint;
            this.isDestroyed = false;
            CollisionDamage = collisionDamage;
            X = x;
            Y = y;
        }

        public Mob()
        {
        }

    }
}
