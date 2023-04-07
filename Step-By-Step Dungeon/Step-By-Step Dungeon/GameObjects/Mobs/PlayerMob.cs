
using System.Xml.Linq;

namespace Step_By_Step_Dungeon
{
    [Serializable]
    public class PlayerMob : Mob
    {
        public int StepsCount { get; set; }

        public delegate int StepOption(int val);

        public bool isOut { get; set; }

        public int MoveHelper(int coordinate, GameObject nextStep, StepOption stepOption)
        {
            if (nextStep is IHasCollision)
            {
                HealthPoint -= ((IHasCollision)nextStep).CollisionDamage;
                if (nextStep is ICanBeDestroyed)
                {
                    ((ICanBeDestroyed)nextStep).HealthPoint -= this.CollisionDamage;
                }
                if (nextStep is EndBlock)
                {
                    isOut = true;
                }
            }
            else
            {
                coordinate = stepOption(coordinate);
            }
            return coordinate;
        }
        public override void Move(GameObject[,] FieldOfVision)
        {
            ConsoleKey move = Console.ReadKey(true).Key;
            StepsCount++;
            GameObject nextStep;
            switch (move)
            {
                case ConsoleKey.A:
                    nextStep = FieldOfVision[Y, X - 1];
                    X = MoveHelper(X, nextStep, (val) => val = val -1);
                    break;
                case ConsoleKey.D:
                    nextStep = FieldOfVision[Y, X + 1];
                    X = MoveHelper(X, nextStep, (val) => val = val + 1);
                    break;
                case ConsoleKey.W:
                    nextStep = FieldOfVision[Y - 1, X];
                    Y = MoveHelper(Y, nextStep, (val) => val = val - 1);
                    break;
                case ConsoleKey.S:
                    nextStep = FieldOfVision[Y + 1, X];
                    Y = MoveHelper(Y, nextStep, (val) => val = val + 1);
                    break;
                case ConsoleKey.Escape:
                    isDestroyed = true;
                    break;
                default:
                    break;
            }
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

        public PlayerMob() 
        {
            Name = "Kolia";
            Description = "The main character of the game that can be controlled.";
            Texture = '8';
            Coloring = ConsoleColor.White;

            X = 1; Y = 1;

            CollisionDamage = 1;

            HealthPoint = 8;
            isDestroyed = false;
            StepsCount = 0;
        }

        public PlayerMob(string name, string description, char texture, ConsoleColor coloring, int x, int y, int collisionDamage, int healthPoint) 
            : base (name, description, texture, coloring, healthPoint, collisionDamage, x, y)
        {
            Name = name;
            Description = description;
            Texture = texture;
            Coloring = coloring;

            X = x; Y = y;

            CollisionDamage = collisionDamage;

            HealthPoint = healthPoint;

            isDestroyed = false;
            StepsCount = 0;
        }
    }
}
