using System.Drawing;
using Task12.Entities;

namespace Task12
{
    public class Round
    {
        public CombatVehicle[] RedTeam { get; set; }
        public CombatVehicle[] BlueTeam { get; set; }
        public int[] redKillsCounter { get; set; }
        public int[] blueKillsCounter { get; set; }

        public Round()
        {
            Random random = new Random();
            int teamCount = random.Next(10, 16);

            RedTeam = new CombatVehicle[teamCount];
            BlueTeam = new CombatVehicle[teamCount];
            redKillsCounter = new int[teamCount];
            blueKillsCounter = new int[teamCount];

            for(int i = 0; i < teamCount; i++)
            {
                switch(random.Next(1, 6))
                {
                    case 1:
                        {
                            RedTeam[i] = new AirDefence();
                            break;
                        }
                    case 2:
                        {
                            RedTeam[i] = new ArmoredCar();
                            break;
                        }
                    case 3:
                        {
                            RedTeam[i] = new Bomber();
                            break;
                        }
                    case 4:
                        {
                            RedTeam[i] = new Fighter();
                            break;
                        }
                    case 5:
                        {
                            RedTeam[i] = new Tank();
                            break;
                        }
                }

                switch (random.Next(1, 6))
                {
                    case 1:
                        {
                            BlueTeam[i] = new AirDefence();
                            break;
                        }
                    case 2:
                        {
                            BlueTeam[i] = new ArmoredCar();
                            break;
                        }
                    case 3:
                        {
                            BlueTeam[i] = new Bomber();
                            break;
                        }
                    case 4:
                        {
                            BlueTeam[i] = new Fighter();
                            break;
                        }
                    case 5:
                        {
                            BlueTeam[i] = new Tank();
                            break;
                        }
                }
            }
        }

        public Round(CombatVehicle[] red, CombatVehicle[] blue)
        {
            RedTeam = red;
            BlueTeam = blue;
            redKillsCounter = new int[RedTeam.Length];
            blueKillsCounter = new int[BlueTeam.Length];
        }

        public void Play()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Random random = new Random();
            int round = 1;

            Console.WriteLine("Red team:");
            foreach (CombatVehicle vehicle in RedTeam)
            {
                Console.WriteLine($"Type: {vehicle.GetType().Name}; Health: {vehicle.Health}; Damage: {vehicle.Attack()}");
            }
            Console.WriteLine();

            Console.WriteLine("Blue team:");
            foreach (CombatVehicle vehicle in BlueTeam)
            {
                Console.WriteLine($"Type: {vehicle.GetType().Name}; Health: {vehicle.Health}; Damage: {vehicle.Attack()}");
            }
            Console.WriteLine();

            while (true)
            {
                Console.WriteLine($"Round {round}; Red team attack: ");
                for(int i = 0; i < RedTeam.Length; i++)
                {
                    if (RedTeam[i].IsDestroyed)
                    {
                        continue;
                    }

                    int attackSelectedIndex = random.Next(0, BlueTeam.Length);

                    if (BlueTeam[attackSelectedIndex].IsDestroyed)
                    {
                        continue;
                    }

                    if (!RedTeam[i].CanAttack(BlueTeam[attackSelectedIndex]))
                    {
                        Console.WriteLine($"Red[{i}] ({RedTeam[i].GetType().Name}) can't attack Blue[{attackSelectedIndex}] ({BlueTeam[i].GetType().Name})");
                        continue;
                    }

                    double damage = RedTeam[i].Attack();
                    BlueTeam[attackSelectedIndex].Defence(damage);

                    if (BlueTeam[attackSelectedIndex].IsDestroyed)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Red[{i}] ({RedTeam[i].GetType().Name}) destroyed Blue[{attackSelectedIndex}] ({BlueTeam[i].GetType().Name}) damaged {damage} health points");
                        Console.ForegroundColor = ConsoleColor.White;
                        redKillsCounter[i]++;
                    }
                    else
                    {
                        Console.WriteLine($"Red[{i}] ({RedTeam[i].GetType().Name}) damaged Blue[{attackSelectedIndex}] ({BlueTeam[i].GetType().Name}) by {damage} health points");
                    }
                }

                Console.WriteLine();
                if (TeamIsDestroyed(BlueTeam))
                {
                    Console.WriteLine("Red team is win!");
                    for(int i = 0; i < RedTeam.Length; i++)
                    {
                        Console.WriteLine($"Red[{i}] ({RedTeam[i].GetType().Name}): {redKillsCounter[i]}");
                    }
                    return;
                }

                Console.WriteLine($"Round {round}; Blue team attack: ");
                for (int i = 0; i < BlueTeam.Length; i++)
                {
                    if (BlueTeam[i].IsDestroyed)
                    {
                        continue;
                    }

                    int attackSelectedIndex = random.Next(0, RedTeam.Length);

                    if (RedTeam[attackSelectedIndex].IsDestroyed)
                    {
                        continue;
                    }

                    if (!BlueTeam[i].CanAttack(RedTeam[attackSelectedIndex]))
                    {
                        Console.WriteLine($"Blue[{i}] ({BlueTeam[i].GetType().Name}) can't attack Red[{attackSelectedIndex}] ({RedTeam[i].GetType().Name})");
                        continue;
                    }

                    double damage = BlueTeam[i].Attack();
                    RedTeam[attackSelectedIndex].Defence(damage);

                    if (RedTeam[attackSelectedIndex].IsDestroyed)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Blue[{i}] ({BlueTeam[i].GetType().Name}) destroyed Red[{attackSelectedIndex}] ({RedTeam[i].GetType().Name}) damaged {damage} health points");
                        Console.ForegroundColor = ConsoleColor.White;
                        blueKillsCounter[i]++;
                    }
                    else
                    {
                        Console.WriteLine($"Blue[{i}] ({BlueTeam[i].GetType().Name}) damaged Red[{attackSelectedIndex}] ({RedTeam[i].GetType().Name}) by {damage} health points");
                    }
                }

                Console.WriteLine();
                if (TeamIsDestroyed(RedTeam))
                {
                    Console.WriteLine("Blue team is win!");
                    for(int i = 0; i < BlueTeam.Length; i++)
                    {
                        Console.WriteLine($"Blue[{i}] ({BlueTeam[i].GetType().Name}): {blueKillsCounter[i]}");   
                    }
                    return;
                }

                round++;
            }
        }

        public bool TeamIsDestroyed(CombatVehicle[] team)
        {
            foreach(CombatVehicle vehicle in team)
            {
                if(!vehicle.IsDestroyed)
                {
                    return false;
                }
            }
            return true;
        }
    }
}