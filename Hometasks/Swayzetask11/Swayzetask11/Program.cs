using System;
using System.Reflection;
using System.Collections.Generic;

namespace Program
{

    public abstract class CombatVehicle
    {
        public string type { get; set; }
        public string model { get; set; }
        public int health { get; set; }

        public bool IsDestroyed()
        {
            if (health <= 0) return true;
            else return false;
        }

        public virtual string ShowInfo()
        {
            return $"Type of Vehicle: {type}.\nModel of vehicle: {model}.\nHealth of vehicle: {health}.";
        }

        public abstract int Attack();
        public abstract int Defense(int damage);

    }

    public class Tank : CombatVehicle
    {
        public int reload { get; set; }
        public int accurance { get; set; }
        public int thickness { get; set; }

        public override int Attack()
        {
            return (100 * accurance) / reload;
        }

        public override int Defense(int damage)
        {
            return damage - thickness;
        }

    }

    public class ArmoredCar : CombatVehicle
    {
        public int count_weapon { get; set; }
        public int speed { get; set; }

        public override int Attack()
        {
            return 50 * count_weapon;
        }
        public override int Defense(int damage)
        {
            return damage - speed / 2;
        }
    }

    public class AirDefenseVehicle : CombatVehicle
    {
        public int lenght { get; set; }
        public int speed_shoot { get; set; }
        public int Mobility { get; set; }

        public override int Attack()
        {
            return (150 + lenght * (speed_shoot / 10));
        }

        public override int Defense(int damage)
        {
            return (damage / Mobility);
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<CombatVehicle> army1 = new List<CombatVehicle>();
            List<CombatVehicle> army2 = new List<CombatVehicle>();
            int army1Count = random.Next(5, 11);
            int army2Count = random.Next(5, 11);

            // Creating armies
            Console.WriteLine("Army 1:");
            for (int i = 0; i < army1Count; i++)
            {
                int vehicleType = random.Next(1, 4);
                if (vehicleType == 1)
                {
                    Tank tank = new Tank()
                    {
                        type = "Tank",
                        model = $"Tank {i + 1}",
                        health = random.Next(500, 1001),
                        reload = random.Next(3, 11),
                        accurance = random.Next(50, 101),
                        thickness = random.Next(20, 51)
                    };
                    army1.Add(tank);
                }
                else if (vehicleType == 2)
                {
                    ArmoredCar armoredCar = new ArmoredCar()
                    {
                        type = "Armored Car",
                        model = $"Armored Car {i + 1}",
                        health = random.Next(300, 601),
                        count_weapon = random.Next(1, 6),
                        speed = random.Next(40, 81)
                    };
                    army1.Add(armoredCar);
                }
                else
                {
                    AirDefenseVehicle airDefenseVehicle = new AirDefenseVehicle()
                    {
                        type = "Air Defense Vehicle",
                        model = $"Air Defense Vehicle {i + 1}",
                        health = random.Next(200, 401),
                        lenght = random.Next(5, 16),
                        speed_shoot = random.Next(10, 31),
                        Mobility = random.Next(3, 6)
                    };
                    army1.Add(airDefenseVehicle);
                }
                Console.WriteLine(army1[i].ShowInfo());
            }
            Console.WriteLine("\nArmy 2:");
            for (int i = 0; i < army2Count; i++)
            {
                int vehicleType = random.Next(1, 4);
                if (vehicleType == 1)
                {
                    Tank tank = new Tank()
                    {
                        type = "Tank",
                        model = $"Tank {i + 1}",
                        health = random.Next(500, 1001),
                        reload = random.Next(3, 11),
                        accurance = random.Next(50, 101),
                        thickness = random.Next(20, 51)
                    };
                    army2.Add(tank);
                }
                else if (vehicleType == 2)
                {
                    ArmoredCar armoredCar = new ArmoredCar()
                    {
                        type = "Armored Car",
                        model = $"Armored Car {i + 1}",
                        health = random.Next(300, 601),
                        count_weapon = random.Next(1, 6),
                        speed = random.Next(40, 81)
                    };
                    army2.Add(armoredCar);
                }
                else
                {
                    AirDefenseVehicle airDefenseVehicle = new AirDefenseVehicle()
                    {
                        type = "Air Defense Vehicle",
                        model = $"Air Defense Vehicle {i + 1}",
                        health = random.Next(200, 401),
                        lenght = random.Next(5, 16),
                        speed_shoot = random.Next(10, 31),
                        Mobility = random.Next(3, 6)
                    };
                    army2.Add(airDefenseVehicle);
                }
                Console.WriteLine(army2[i].ShowInfo());
            }

            Console.WriteLine("\nPress any key to start the battle...");
            Console.ReadKey();
            Console.WriteLine("\n=== BATTLE STARTED ===\n");

            int army1Index = 0;
            int army2Index = 0;

            while (army1.Count > 0 && army2.Count > 0)
            {
                CombatVehicle bm1 = army1[army1Index];
                CombatVehicle bm2 = army2[army2Index];

                Console.WriteLine($"{bm1.model} from Army 1 is attacking {bm2.model} from Army 2...");
                Console.WriteLine($"{bm1.model} deals {bm2.Defense(bm1.Attack())} damage to {bm2.model}");

                if (bm2.IsDestroyed())
                {
                    Console.WriteLine($"{bm2.model} from Army 2 is destroyed!");
                    army2.RemoveAt(army2Index);
                }
                else
                {
                    Console.WriteLine($"{bm2.model} is still alive with {bm2.health} health remaining.");
                    Console.WriteLine($"{bm2.model} from Army 2 is attacking {bm1.model} from Army 1...");
                    Console.WriteLine($"{bm2.model} deals {bm1.Defense(bm2.Attack())} damage to {bm1.model}");

                    if (bm1.IsDestroyed())
                    {
                        Console.WriteLine($"{bm1.model} from Army 1 is destroyed!");
                        army1.RemoveAt(army1Index);
                        army2Index++;
                    }
                    else
                    {
                        Console.WriteLine($"{bm1.model} from Army 1 attacks {bm2.model} from Army 2.");
                        int damage = bm1.Attack();
                        int remainingHealth = bm2.Defense(damage);
                        bm2.health -= remainingHealth;
                        Console.WriteLine($"{bm2.model} from Army 2 takes {remainingHealth} damage.");
                        if (bm2.IsDestroyed())
                        {
                            Console.WriteLine($"{bm2.model} from Army 2 is destroyed!");
                            army2.RemoveAt(army2Index);
                        }
                        else
                        {
                            army2Index++;
                        }
                    }
                    if (army2Index >= army2.Count)
                    {
                        Console.WriteLine("\n*** Army 1 Wins! ***\n");
                        break;
                    }

                    CombatVehicle bm3 = army2[army2Index];
                    Console.WriteLine($"{bm3.model} from Army 2 attacks {bm1.model} from Army 1.");
                    int damage2 = bm3.Attack();
                    int remainingHealth2 = bm1.Defense(damage2);
                    bm1.health -= remainingHealth2;
                    Console.WriteLine($"{bm1.model} from Army 1 takes {remainingHealth2} damage.");
                    if (bm1.IsDestroyed())
                    {
                        Console.WriteLine($"{bm1.model} from Army 1 is destroyed!");
                        army1.RemoveAt(army1Index);
                        army2Index++;
                    }
                    else
                    {
                        army1Index++;
                    }

                    if (army1Index >= army1.Count)
                    {
                        Console.WriteLine("\n*** Army 2 Wins! ***\n");
                        break;
                    }
                }
            }
        }

    }
}