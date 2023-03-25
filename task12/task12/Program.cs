

namespace task12
{
    using System;

    public abstract class CombatVehicle
    {
        public string type;
        public string model;
        public int health;

        public CombatVehicle(string type, string model, int health)
        {
            this.type = type;
            this.model = model;
            this.health = health;
        }

        public virtual bool IsDestroyed()
        {
            return health <= 0;
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

    public class ClassWarsGame
    {
        public static void Main()
        {
            Random random = new Random();

            // Армія 1
            List<CombatVehicle> army1 = new List<CombatVehicle>();
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
                            army1.Add(armoredCar);
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
                            army1.Add(airDefenseVehicle);
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
                            army1.Add(tank);
                            break;
                        }
                }
            }

            // Армія 2
            List<CombatVehicle> army2 = new List<CombatVehicle>();
            int numVehicles2 = random.Next(5, 11);
            for (int i = 0; i < numVehicles2; i++)
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
                                    model = "Stryker";
                                    break;
                                case 2:
                                    model = "LAV-25";
                                    break;
                                case 3:
                                    model = "Patria AMV";
                                    break;
                            }

                            int health = random.Next(100, 201);
                            int C = random.Next(1, 6);
                            int S = random.Next(50, 101);

                            ArmoredCar armoredCar = new ArmoredCar(model, health, C, S);
                            army2.Add(armoredCar);
                            break;
                        }
                    case 2:
                        {
                            int modelNum = random.Next(1, 4);
                            string model = "";
                            switch (modelNum)
                            {
                                case 1:
                                    model = "Bofors 40mm";
                                    break;
                                case 2:
                                    model = "ZSU-23-4 Shilka";
                                    break;
                                case 3:
                                    model = "Pantsir-S1";
                                    break;
                            }
                        
                            int health = random.Next(100, 201);
                            int L = random.Next(100, 201);
                            int R = random.Next(1, 6);
                            int M = random.Next(1, 11);

                            AirDefenseVehicle airDefenseVehicle = new AirDefenseVehicle(model, health, L, R, M);
                            army2.Add(airDefenseVehicle);
                            break;
                        }
                    case 3:
                        {
                            int modelNum = random.Next(1, 4);
                            string model = "";
                            switch (modelNum)
                            {
                                case 1:
                                    model = "M1A2 Abrams";
                                    break;
                                case 2:
                                    model = "M2/M3 Bradley";
                                    break;
                                case 3:
                                    model = "M1128 Stryker";
                                    break;
                            }

                            int health = random.Next(100, 201);
                            int A = random.Next(1, 8);
                            int R = random.Next(1, 10);
                            int T = random.Next(1, 20);

                            Tank tank = new Tank(model, health, R, A, T);
                            army2.Add(tank);
                            break;
                        }
                }
            }
            
            Console.WriteLine("Army 1:");
            foreach (CombatVehicle vehicle in army1)
            {
                vehicle.ShowInfo();
            }
            Console.WriteLine("Army 2:");
            foreach (CombatVehicle vehicle in army2)
            {
                vehicle.ShowInfo();
            }
        }
    }
}

       