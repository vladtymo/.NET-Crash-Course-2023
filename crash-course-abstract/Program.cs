using System;
using System.Xml;

namespace crash_course_abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Warning! This game is completely disbalanced!\n Have fun!");

            Random random = new Random();
            int armySize = random.Next(5, 10);
            int armySize2 = random.Next(5, 10);

            CombatVehicle[] army1 = GenerateArmy(armySize);
            CombatVehicle[] army2 = GenerateArmy(armySize2);

            int randomVehicle1;
            int randomVehicle2;
            int destroyedVehicle1 = 0;
            int destroyedVehicle2 = 0;
            bool destroyedArmy;



            while (destroyedVehicle1 == armySize || destroyedVehicle2 == armySize2)
            {
                randomVehicle1 = random.Next(armySize);
                randomVehicle2 = random.Next(armySize2);
                destroyedArmy = Round(army1[randomVehicle1], army2[randomVehicle2]);
                if (destroyedArmy) destroyedVehicle1++;
                else destroyedVehicle2++;
            }
        }

        static CombatVehicle[] GenerateArmy(int armySize)
        {
            Random random = new Random();

            CombatVehicle[] army = new CombatVehicle[armySize];

            string[] tankModels = { "Challanger-2", "Tiger", "Leopard-1" };
            string[] carModels = { "ICM 1/35", "Hammer", "M1240A1" };
            string[] artModels = { "SAU-122", "SU-122", "D-30" };
            int randomType;
            int randModel;

            for (int i = 0; i < armySize; i++)
            {
                randomType = random.Next(1,3);
                if ((Types)randomType == Types.Artillery)
                {
                    randModel = random.Next(0, 2);
                    army[i] = new AirDefenceVehicle(
                        artModels[randModel],
                        random.Next(100, 200),
                        (Types)randomType,
                        random.Next(10, 15),
                        random.Next(3),
                        random.Next(10)
                        );
                }
                else if ((Types)randomType == Types.HardVehicle)
                {
                    randModel = random.Next(0, 2);
                    army[i] = new Tank(
                        tankModels[randModel],
                        random.Next(250, 400),
                        (Types)randomType,
                        random.Next(20, 35),
                        random.Next(3),
                        random.Next(10, 50)
                        );
                }
                else
                {
                    randModel = random.Next(0, 2);
                    army[i] = new ArmoredCar(
                        carModels[randModel],
                        random.Next(100, 150),
                        (Types)randomType,
                        random.Next(3),
                        random.Next(10, 50)
                        );
                }
            }

            return army;
        }

        static bool Round(CombatVehicle vehicle1, CombatVehicle vehicle2)
        {
            while (vehicle1.IsDestroyed() == false || vehicle2.IsDestroyed() == false)
            {
                vehicle1.Health -= vehicle1.Defence(vehicle2.Attack());
                vehicle2.Health -= vehicle2.Defence(vehicle1.Attack());

                Console.WriteLine(new string('-', 25));
                vehicle1.ShowInfo();
                vehicle2.ShowInfo();
            }

            if (vehicle1.IsDestroyed())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
} 