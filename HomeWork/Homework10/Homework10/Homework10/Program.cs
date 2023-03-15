using Homework10;

using System;
using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;

namespace Homework10
{


    public abstract class CombatVehicle
    {
        public string type;
        public string model;
        public int health;
        private static readonly Random rand = new Random();


        public bool IsDestroyed()
        {
            return health <= 0;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Type: {type}\n Model: {model}\n Health: {health}");
        }

        public abstract int Attack();

        public abstract void Defense(int damage);
        public static int GetRandomNumber(int min, int max)
        {
            return rand.Next(min, max + 1);
        }
    }

    class Tank : CombatVehicle
    {
        public int reloadTime;
        public int accuracy;
        public int armorThickness;

        public Tank(string model)
        {
            type = "Tanks";
            this.model = model;
            health = 100;
            reloadTime = GetRandomNumber(5, 10);
            accuracy = GetRandomNumber(50, 101);
            armorThickness = GetRandomNumber(10, 21);
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Reload Time: {reloadTime}s\n, Accuracy: {accuracy}%\nArmor Thickness: {armorThickness}mm\n");
        }

        public override int Attack()
        {
            return 100 * accuracy / reloadTime;
        }

        public override void Defense(int damage)
        {
            health -= damage - armorThickness;
        }
    }

    class ArmoredCar : CombatVehicle
    {
        public int weaponCount;
        public int speed;

        public ArmoredCar(string model)
        {
            type = "Armored Cars";
            this.model = model;
            health = 50;
            weaponCount = GetRandomNumber(1, 6);
            speed = GetRandomNumber(30, 71);
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Weapon Count: {weaponCount}, Speed: {speed} km/h\n");
        }

        public override int Attack()
        {
            return 50 * weaponCount;
        }

        public override void Defense(int damage)
        {
            health -= damage - speed / 2;
        }
    }

    class AirDefenseVehicle : CombatVehicle
    {
        public int range;
        public int shootingSpeed;
        public int mobility;

        public AirDefenseVehicle(string model)
        {
            type = "Air Defense Vehicles";
            this.model = model;
            health = 150;
            range = GetRandomNumber(100, 1001);
            shootingSpeed = GetRandomNumber(1, 4);
            mobility = GetRandomNumber(1, 11);
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Range: {range}, Shooting Speed: {shootingSpeed} , Mobility: {mobility}/10\n");
        }

        public override int Attack()
        {
            return 150 + range * shootingSpeed / 10;
        }

        public override void Defense(int damage)
        {
            health -= damage / mobility;
        }
    }


    public class Program
    {
        static CombatVehicle[] CreateArmy()
        {
            CombatVehicle[] army = new CombatVehicle[GetRandomNumber(5, 10)];
            for (int i = 0; i < army.Length; i++)
            {
                int vehicleType = GetRandomNumber(1, 3);
                switch (vehicleType)
                {
                    case 1: army[i] = new Tank($"Tank{i + 1}"); break;
                    case 2: army[i] = new ArmoredCar($"ArmoredCar{i + 1}"); break;
                    case 3: army[i] = new AirDefenseVehicle($"AirDefenceVehicle{i + 1}"); break;
                }

            }

            return army;
        }

        static CombatVehicle ChooseVehicle(CombatVehicle[] army)
        {
            int index = GetRandomNumber(0, army.Length - 1);
            while (army[index] == null || army[index].IsDestroyed())
            {
                index = GetRandomNumber(0, army.Length - 1);
            }
            return army[index];


        }

        static bool Round(CombatVehicle bm1, CombatVehicle[]  armyType1, CombatVehicle bm2, CombatVehicle[] armyType2)
        {
            bool team;
            //Show information about vehicle selected:
            Console.WriteLine($"\n {bm1.model} vs  {bm2.model}\n");

            // Start round
            while (true) {
                // 1st vehicle attack, 2st vehicle defend.
                int damage = bm1.Attack();
            Console.WriteLine($"{bm1.model} attacks {bm2.model} for {damage} damage!\n");
            bm2.Defense(damage);
            if (bm2.IsDestroyed())
            {
                Console.WriteLine($"{bm2.model} is destroyed!\n");
                RemoveVehicle(armyType2, bm2);
                    return true;
            }
            // 2st vehicle attack, 1st vehicle defend.
            damage = bm2.Attack();
            Console.WriteLine($"{bm2.model} attacks {bm1.model} for {damage} damage!\n");
            bm1.Defense(damage);
            if (bm1.IsDestroyed())
            {
                Console.WriteLine($"{bm1.model} is destroyed!\n");
                    RemoveVehicle(armyType1, bm1);
                    return false;
                    
            }

            }


        }

        // Method delete vehicle
        static void RemoveVehicle(CombatVehicle[] army, CombatVehicle vehicle)
        {
            for (int i = 0; i < army.Length; i++)
            {
                if (army[i] == vehicle)
                {
                    army[i] = null;
                    break;
                }
            }
        }

        static void Main(string[] args)
        {
            CombatVehicle[] army1 = CreateArmy();
            CombatVehicle[] army2 = CreateArmy();

            Console.WriteLine("First army:");
            for (int i = 0; i < army1.Length; i++)
            {
                army1[i].ShowInfo();
            }

            Console.WriteLine("Second army:");
            for (int i = 0; i < army2.Length; i++)
            {
                army2[i].ShowInfo();
            }

            int round = 1;
            while (army1.Length > 0 & army2.Length > 0)
            {

                CombatVehicle bm1 = army1[GetRandomNumber(0, army1.Length - 1)];

                CombatVehicle bm2 = army2[GetRandomNumber(0, army2.Length - 1)];


                Console.WriteLine($"\nRound {round}:\n");


                Console.WriteLine($"\tArmy1 = {army1.Length} vehicles\n\tArmy2 = {army2.Length} vehicles");

                Console.WriteLine($"Battle: {bm1.type} {bm1.model} vs {bm2.type} {bm2.model}\n");

                bool result = Round(bm1,army1, bm2,army2);
                //filtered massive, delete all elements contains null
                army2 = army2.Where(x => x != null).ToArray();
                army1 = army1.Where(x => x != null).ToArray();


                if (result)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"Army 1: {bm1.model} wins the round\n");
                    Console.ResetColor();


                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Army 2: {bm2.model} wins the round\n");
                    Console.ResetColor();


                }

                round++;
            }
            
            if (army1.Length == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Second army wins the battle");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("First army wins the battle");
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nHit the key to end game");
            Console.ReadKey();
        }
    
    









private static readonly Random rand = new Random();
        public static int GetRandomNumber(int min, int max)
        {
            return rand.Next(min, max + 1);
        }
    }
}




           