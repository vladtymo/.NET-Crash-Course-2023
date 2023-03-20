namespace lesson_12_HW_abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            War();
        }
        static List<CombatVehicle> CreateArray()
        {
            List<CombatVehicle> war = new List<CombatVehicle>();
            Random rnd = new Random();
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("\nОберіть тип: \n" +
                    "1 - Tank\n" +
                    "2 - Armored Car\n" +
                    "3 - AirDefence Vehicle");
                string choose = Console.ReadLine();
                Console.WriteLine("Введіть модель: ");
                string model = Console.ReadLine();
                switch (choose)
                {
                    case "1":
                        war.Add(new Tank(model, rnd.Next(90,100))
                        {
                            ReloadTime = rnd.Next(10),
                            ShotAccurancy = rnd.Next(10),
                            ArmorThinkness = rnd.Next(20)
                        });
                        break;
                    case "2":
                        war.Add( new ArmoredCar(model, rnd.Next(90,100))
                        {
                            CountOfWeapons = rnd.Next(6),
                            Speed = rnd.Next(60,160)/2.0
                        });
                        break;
                    case "3":
                        war.Add( new AirDefenceVehicle(model, rnd.Next(90, 100), rnd.Next(10))
                        {
                            Range = rnd.Next(200, 400),
                            RateOfFire = rnd.Next(10) + rnd.NextDouble()
                        });
                        break;
                    default:
                        Console.WriteLine("Такого варіанту немає!");
                        i-=1;
                        break;
                }
            }
            return war;
        }
        static void War()
        {
            Console.WriteLine("Зброя гравця №1");
            List<CombatVehicle> war1 = CreateArray();
            Console.WriteLine("Зброя гравця №2");
            List<CombatVehicle> war2 = CreateArray();
            Random rnd = new Random();

            int numOfRound = 1;
            while (war1.Count > 0 && war2.Count > 0)
            {
                Console.WriteLine(new string('-', 10) + "Раунд №" + numOfRound + new string('-', 10));

                int randomChoose = rnd.Next(1, 3);
                int numVehicle1 = rnd.Next(war1.Count);
                int numVehicle2 = rnd.Next(war2.Count);
                if (randomChoose == 1)
                {
                    Console.WriteLine("Армія №1");
                    war1[numVehicle1].ShowInfo();
                    Console.WriteLine("\nАрмія №2");
                    war2[numVehicle2].ShowInfo();

                    double damage = war1[numVehicle1].Attack();
                    war2[numVehicle2].Defance(damage);

                    damage = war2[numVehicle2].Attack();
                    war1[numVehicle1].Defance(damage);
                }
                else
                {
                    Console.WriteLine("Армія №2");
                    war2[numVehicle2].ShowInfo();
                    Console.WriteLine("\nАрмія №1");
                    war1[numVehicle1].ShowInfo();

                    double damage = war2[numVehicle2].Attack();
                    war1[numVehicle1].Defance(damage);

                    damage = war1[numVehicle1].Attack();
                    war2[numVehicle2].Defance(damage);
                }

                if (war1[numVehicle1].IsDestoyed())
                    war1.Remove(war1[numVehicle1]);
                else if (war2[numVehicle2].IsDestoyed())
                    war2.Remove(war2[numVehicle2]);

                numOfRound++;
            }
            if(war1.Count == 0)
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