
using Newtonsoft.Json;
using System.Xml.Linq;

namespace Step_By_Step_Dungeon
{
    public class StaticMob : Mob
    {
        public override object Clone()
        {
            string json = JsonConvert.SerializeObject(this);
            return JsonConvert.DeserializeObject<object>(json);
        }

        public override void Move(GameObject[,] FieldOfVision)
        {
        }

        public override void HealthUpdate()
        {
            if (HealthPoint <= 0)
            {
                isDestroyed = true;
            }
            else
            {
                isDestroyed = false;
            }
        }

        public StaticMob()
        {
            Name = "HealPotion";
            Description = "A peaceful animal that runs chaotically.";
            Texture = '+';
            Coloring = ConsoleColor.Red;

            X = 7; Y = 7;

            CollisionDamage = -2;

            HealthPoint = 3;
            isDestroyed = false;
        }

        public StaticMob(string name, string description, char texture, ConsoleColor coloring, int x, int y, int collisionDamage, int healthPoint, bool isDestroyed)
            : base(name, description, texture, coloring, healthPoint, collisionDamage, x, y)
        {
            Name = name;
            Description = description;
            Texture = texture;
            Coloring = coloring;

            X = x; Y = y;

            CollisionDamage = collisionDamage;

            HealthPoint = healthPoint;
            isDestroyed = false;
        }
    }
}
