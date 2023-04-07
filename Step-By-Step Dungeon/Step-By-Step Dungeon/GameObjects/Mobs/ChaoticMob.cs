
using Newtonsoft.Json;
using static Step_By_Step_Dungeon.PlayerMob;

namespace Step_By_Step_Dungeon
{
    public class ChaoticMob : Mob
    {
        public delegate int StepOption(int val);

        public override object Clone()
        {
            string json = JsonConvert.SerializeObject(this);
            return JsonConvert.DeserializeObject<object>(json);
        }

        public int MoveHelper(int coordinate, GameObject nextStep, StepOption stepOption)
        {
            if (nextStep is IHasCollision)
            {
                HealthPoint -= ((IHasCollision)nextStep).CollisionDamage;
                if (nextStep is ICanBeDestroyed)
                {
                    ((ICanBeDestroyed)nextStep).HealthPoint -= this.CollisionDamage;
                }
                Random random = new Random();
            }
            else
            {
                coordinate = stepOption(coordinate);
            }
            return coordinate;
        }

        public override void Move(GameObject[,] FieldOfVision)
        {
            Random random = new Random();
            int movementDirection = random.Next(1, 5);

            GameObject nextStep;
            switch (movementDirection)
            {
                case 1:
                    nextStep = FieldOfVision[Y, X - 1];
                    X = MoveHelper(X, nextStep, (val) => val = val - 1);
                    break;
                case 2:
                    nextStep = FieldOfVision[Y, X + 1];
                    X = MoveHelper(X, nextStep, (val) => val = val + 1);
                    break;
                case 3:
                    nextStep = FieldOfVision[Y - 1, X];
                    Y = MoveHelper(Y, nextStep, (val) => val = val - 1);
                    break;
                case 4:
                    nextStep = FieldOfVision[Y + 1, X];
                    Y = MoveHelper(Y, nextStep, (val) => val = val + 1);
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

        public ChaoticMob()
        {
            Name = "Bunny";
            Description = "A peaceful animal that runs chaotically.";
            Texture = 'b';
            Coloring = ConsoleColor.Magenta;

            X = 4; Y = 4;

            CollisionDamage = 0;

            HealthPoint = 3;
            isDestroyed = false;
        }

        public ChaoticMob(string name, string description, char texture, ConsoleColor coloring, int x, int y, int collisionDamage, int healthPoint, bool isDestroyed)
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
