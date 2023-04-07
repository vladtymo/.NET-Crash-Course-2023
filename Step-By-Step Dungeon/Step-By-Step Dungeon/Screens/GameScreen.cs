
using System.Drawing;
using System.Runtime.Serialization.Formatters.Binary;

namespace Step_By_Step_Dungeon
{
    [Serializable]
    public class GameScreen : Screen
    {
        public FloorBlock Floor { get; set; }
        public WallBlock Wall { get; set; }
        public EndBlock End { get; set; }
        public PlayerMob Player { get; set; }

        public Mob[] MobArray { get; set; }

        public GameObject[,] Matrix { get; set; }

        public int[,] PlanMatrix { get; set; }

        public override void Load(ScreenLib screenLib)
        {
            base.Load(screenLib);
            PlanMatrix = new int[SizeY, SizeX];
            Random random = new Random();

            for (int i = 0; i < SizeY; i++)
            {
                for (int j = 0; j < SizeX; j++)
                {
                    PlanMatrix[i, j] = random.Next(1, 10);
                }
            }
            Option(screenLib);
        }
        protected override void Option(ScreenLib screenLib)
        {
            bool end = false;
            while (!end)
            {
                GenerateGame();
                DrawGame();
                foreach (GameObject obj in Matrix)
                {
                    if (obj is Mob)
                    {
                        ((Mob)obj).HealthUpdate();
                        ((Mob)obj).Move(this.Matrix);
                    }
                }
                if (Player.isDestroyed)
                {
                    screenLib.End.Success = false;
                    end = true;
                }
                if (Player.isOut)
                {
                    screenLib.End.Success = true;
                    end = true;
                }
            }
            screenLib.End.Load(screenLib);
        }

        public void GenerateGame()
        {
            
            Matrix = new GameObject[SizeY, SizeX];

            for (int i = 0; i < SizeY; i++)
            {
                for (int j = 0; j < SizeX; j++)
                {
                    if (PlanMatrix[i, j] == 1)
                    {
                        Matrix[i, j] = Wall;
                    }
                    else if (PlanMatrix[i, j] == 2)
                    {
                        Matrix[i, j] = MobArray[0];
                        ((Mob)Matrix[i, j]).X = j;
                        ((Mob)Matrix[i, j]).Y = i;
                    }
                    else
                    {
                        Matrix[i, j] = Floor;
                    }
                }
            }

            for (int i = 0; i < SizeY; i++)
            {
                for (int j = 0; j < SizeX; j++)
                {
                    if (j == 0 || j == (SizeX - 1) || i == 0 || i == (SizeY - 1))
                    {
                        Matrix[i, j] = Wall;
                    }
                    else
                    {
                        
                    }
                }
            }


            foreach (Mob obj in MobArray)
            {
                if (!obj.isDestroyed)
                {
                    Matrix[obj.Y, obj.X] = obj;
                }
            }

            
            Matrix[End.Y, End.X] = End;
            Matrix[Player.Y, Player.X] = Player;

            Console.SetCursorPosition(0, SizeY);
            Console.WriteLine(new string('-', SizeX));
            Console.Write($"HP: {Player.HealthPoint}");
            
            Console.WriteLine();
            Console.WriteLine($"STEPS: {Player.StepsCount}");

        }

        public void DrawHelper(GameObject gO)
        {
            for (int i = 0; i < SizeY; i++)
            {
                for (int j = 0; j < SizeX; j++)
                {
                    if (Matrix[i, j] == gO)
                    {
                        Console.SetCursorPosition(j, i);
                        Console.Write(gO.Visualize());
                    }
                    else { }
                }
            }
            Console.ResetColor();
        }

        public void DrawGame()
        {
            DrawHelper(Floor);
            DrawHelper(Wall);
            DrawHelper(Player);
            foreach (Mob wan in MobArray)
            {
                DrawHelper(wan);
            }
            DrawHelper(End);

        }

    }
}
