

namespace task12
{
    using System;

    public abstract class CombatVehicle
    {
        public string type { get; set; }
        public string model { get; set; }
        public int health { get; set; }

        public CombatVehicle(string type, string model, int health)
        {
            this.type = type;
            this.model = model;
            this.health = health;
        }

        public virtual bool IsDestroyed()
        {
            if (health > 0) return false;
            else return true;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine("Type: {0}\nModel: {1}\nHealth: {2}\n", type, model, health);
        }

        public abstract int Attack();

        public abstract void Defense(int damage);
    }

    public class Tank : CombatVehicle
    {
        public int R; // reload time
        public int A; // accuracy
        public int T; // armor thickness

        public Tank(string model, int health, int R, int A, int T)
            : base("Tank", model, health)
        {
            this.R = R;
            this.A = A;
            this.T = T;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Reload time: {0}\nAccuracy: {1}\nArmor thickness: {2}\n", R, A, T);
        }

        public override int Attack()
        {
            return 100 * A / R;
        }

        public override void Defense(int damage)
        {
            health -= damage - T;
        }
    }

    public class ArmoredCar : CombatVehicle
    {
        public int C; // amount of weapons
        public int S; // speed

        public ArmoredCar(string model, int health, int C, int S)
            : base("Armored Car", model, health)
        {
            this.C = C;
            this.S = S;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Amount of weapons: {0}\nSpeed: {1}\n", C, S);
        }

        public override int Attack()
        {
            return 50 * C;
        }

        public override void Defense(int damage)
        {
            health -= damage - S / 2;
        }
    }

    public class AirDefenseVehicle : CombatVehicle
    {
        public int L; // range
        public int R; // firing speed
        public int M; // mobility rating (1-10)

        public AirDefenseVehicle(string model, int health, int L, int R, int M)
            : base("Air Defense Vehicle", model, health)
        {
            this.L = L;
            this.R = R;
            this.M = M;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Range: {0}\nFiring speed: {1}\nMobility rating: {2}\n", L, R, M);
        }

        public override int Attack()
        {
            return 150 + L * (R / 10);
        }

        public override void Defense(int damage)
        {
            health -= damage / M;
        }
    }

    public class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            BattleRound();
        }

        static List<CombatVehicle> CreateArmy()
        {
            Random random = new Random();
            List<CombatVehicle> army = new List<CombatVehicle>();
            int numVehicles1 = random.Next(5, 11);
            for (int i = 0; i < numVehicles1; i++)
            {
                int vehicleType = random.Next(1, 4);
                switch (vehicleType)
                {
                    case 1:
                        {
                            int modelNum = random.Next(1, 4);
                            string model = "";
                            switch (modelNum)
                            {
                                case 1:
                                    model = "FV510 Warrior";
                                    break;
                                case 2:
                                    model = "FV432";
                                    break;
                                case 3:
                                    model = "FV107 Scimitar";
                                    break;
                            }

                            int health = random.Next(100, 201);
                            int C = random.Next(1, 6);
                            int S = random.Next(50, 101);

                            ArmoredCar armoredCar = new ArmoredCar(model, health, C, S);
                            army.Add(armoredCar);
                            break;
                        }
                    case 2:
                        {
                            int modelNum = random.Next(1, 4);
                            string model = "";
                            switch (modelNum)
                            {
                                case 1:
                                    model = "BAE Systems Bloodhound";
                                    break;
                                case 2:
                                    model = "Rapier";
                                    break;
                                case 3:
                                    model = "Starstreak";
                                    break;
                            }

                            int health = random.Next(100, 201);
                            int L = random.Next(100, 201);
                            int R = random.Next(1, 6);
                            int M = random.Next(1, 11);

                            AirDefenseVehicle airDefenseVehicle = new AirDefenseVehicle(model, health, L, R, M);
                            army.Add(airDefenseVehicle);
                            break;
                        }
                    case 3:
                        {
                            int modelNum = random.Next(1, 4);
                            string model = "";
                            switch (modelNum)
                            {
                                case 1:
                                    model = "Challenger 2";
                                    break;
                                case 2:
                                    model = "Ajax";
                                    break;
                                case 3:
                                    model = "Warrior";
                                    break;
                            }

                            int health = random.Next(100, 201);
                            int A = random.Next(1, 8);
                            int R = random.Next(1, 10);
                            int T = random.Next(1, 20);

                            Tank tank = new Tank(model, health, R, A, T);
                            army.Add(tank);
                            break;
                        }
                }
            }
            return army;
          
            }
        static void BattleRound()
        {
            Console.WriteLine("Зброя гравця №1");
            List<CombatVehicle> army1 = CreateArmy();
            Console.WriteLine("Зброя гравця №2");
            List<CombatVehicle> army2 = CreateArmy();
            Random rnd = new Random();

            int numOfRound = 1;
            while (army1.Count > 0 && army2.Count > 0)
            {
                Console.WriteLine(new string('-', 10) + "Раунд " + numOfRound + new string('-', 10));

                int randomChoose = rnd.Next(1, 3);
                int numVehicle1 = rnd.Next(army1.Count);
                int numVehicle2 = rnd.Next(army2.Count);
                if (randomChoose == 1)
                {
                    Console.WriteLine("Армія 1");
                    army1[numVehicle1].ShowInfo();
                    Console.WriteLine("\nАрмія 2");
                    army2[numVehicle2].ShowInfo();

                    int damage = army1[numVehicle1].Attack();
                    army2[numVehicle2].Defense(damage);

                    damage = army2[numVehicle2].Attack();
                    army1[numVehicle1].Defense(damage);
                }
                else
                {
                    Console.WriteLine("Армія 1");
                    army2[numVehicle2].ShowInfo();
                    Console.WriteLine("\nАрмія 2");
                    army1[numVehicle1].ShowInfo();

                    int damage = army2[numVehicle2].Attack();
                    army1[numVehicle1].Defense(damage);

                    damage = army1[numVehicle1].Attack();
                    army2[numVehicle2].Defense(damage);
                }

                if (army1[numVehicle1].IsDestroyed())
                    army1.Remove(army1[numVehicle1]);
                else if (army2[numVehicle2].IsDestroyed())
                    army2.Remove(army2[numVehicle2]);

                numOfRound++;
            }
            if (army1.Count == 0)
            {
                Console.WriteLine("Друга армія перемогла!");
            }
            else
            {
                Console.WriteLine("Перша армія перемогла");
            }
        }
    }
}

       