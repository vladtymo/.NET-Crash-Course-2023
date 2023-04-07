
using System.Xml.Linq;

namespace Step_By_Step_Dungeon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int sizeX = 60;
            const int sizeY = 20;

            EndBlock endBlock = new()
            {
                X = sizeX - 2,
                Y = sizeY - 2,
            };

            PlayerMob player = new PlayerMob()
            {
                Coloring = ConsoleColor.Blue,
            };

            StaticMob heal = new StaticMob();

            //----------------------
            FloorBlock cobblestone = new FloorBlock();
            WallBlock stone = new WallBlock();
            WanderingMob snake = new WanderingMob(){};
            WanderingMob bigSnake = new WanderingMob()
            {
                Name = "Big snake",
                Description = "Big Sssssnake",
                Coloring = ConsoleColor.Red,
                Texture = 'S',
                HealthPoint = 5,
                CollisionDamage = 3,
                X = 5,
                Y = 7,
            };
            //----------------------
            FloorBlock grass = new FloorBlock()
            { 
                Name = "Grass",
                Description = "Grass block",
                Coloring = ConsoleColor.Green,
                Texture = '"'
            };
            WallBlock bush = new WallBlock()
            {
                Name = "Bush",
                Description = "Bush block",
                Coloring = ConsoleColor.DarkGreen,
                Texture = 'W',
                CollisionDamage = 0,
            };
            StaticMob spike = new StaticMob()
            {
                Name = "Spike",
                Description = "Spike block",
                Coloring = ConsoleColor.Yellow,
                Texture = '^',
                HealthPoint = 1,
                CollisionDamage = 1,
                X = 5,
                Y = 7,
            };
            ChaoticMob monkey = new ChaoticMob()
            {
                Name = "Monkey",
                Description = "Monkey mob",
                Texture = '&',
                Coloring = ConsoleColor.DarkYellow,
                X = 4,
                Y = 4,
                CollisionDamage = 2,
                HealthPoint = 7,
            };
            //----------------------

            ChaoticMob bunny = new ChaoticMob();

            ChaoticMob bigBunny = new ChaoticMob()
            {
                Name = "Big Bunny",
                Description = "Big Bunny",
                Coloring = ConsoleColor.Magenta,
                Texture = 'B',
                HealthPoint = 8,
                CollisionDamage = 1,
                X = 5,
                Y = 7,
            };

            FloorBlock flowers = new FloorBlock()
            {
                Name = "Flowers",
                Description = "Flowers block",
                Coloring = ConsoleColor.DarkMagenta,
                Texture = '*'
            };
            WallBlock lava = new WallBlock()
            {
                Name = "Lava",
                Description = "Lava block",
                Coloring = ConsoleColor.Red,
                Texture = 'O',
                CollisionDamage = 1,
            };

            //----------------------

            GameScreen[] Game = new GameScreen[]{
                    new()
                    {
                        SizeX = sizeX,
                        SizeY = sizeY,
                        Wall = stone,
                        Floor = cobblestone,
                        Player = player,
                        MobArray = new Mob[]{ snake, bigSnake, heal },
                        End = endBlock,
                        Name = "Snake Pit"

                    },
                    new()
                    {
                        SizeX = sizeX,
                        SizeY = sizeY,
                        Wall = bush,
                        Floor = grass,
                        Player = player,
                        MobArray = new Mob[]{ spike, monkey, heal},
                        End = endBlock,
                        Name = "Omnious Jungle"

                    },
                    new()
                    {
                        SizeX = sizeX,
                        SizeY = sizeY,
                        Wall = lava,
                        Floor = flowers,
                        Player = player,
                        MobArray = new Mob[]{ bunny, bigBunny, heal },
                        End = endBlock,
                        Name = "Bunny Madness"

                    }
            };

            EndScreen end = new()
            {
                SizeX = sizeX,
                SizeY = sizeY,
            };      

            LevelsScreen level = new()
            {
                SizeX = sizeX,
                SizeY = sizeY,
            };

            ManualScreen manual = new()
            {
                SizeX = sizeX,
                SizeY = sizeY,
            };

            StartScreen start = new()
            {
                SizeX = sizeX,
                SizeY = sizeY,
            };

            ScreenLib scr1 = new ScreenLib()
            {
                End = end,
                Game= Game,
                Start= start,
                Levels = level,
                Manual = manual
            };

            start.Load(scr1);
        }
    }
}