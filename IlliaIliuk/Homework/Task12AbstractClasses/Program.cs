namespace Task12AbstractClasses
{
    internal class ClassWars
    {
        static bool Round(CombatVehicle bm1, CombatVehicle bm2)
        {
            while (bm1.IsDestroyed() == false && bm2.IsDestroyed() == false)
            {
                bm1.Defense(bm2.Attack());
                if (bm1.IsDestroyed())
                {
                    return false;
                }
                bm2.Defense(bm1.Attack());
                if (bm2.IsDestroyed())
                {
                    return true;
                }
            }
            if (bm2.IsDestroyed())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            Random random = new();

            CombatVehicle[] army1 =
            {
                new Tank("tank","1",random.Next(1000),random.Next(1000),random.Next(1000),random.Next(1000)),
                new ArmoredCar("ArmoredCar","4",random.Next(1000),random.Next(),random.Next(1000)),
                new AirDefenseVehicle("AirDefenseVehicle","1",random.Next(1000),random.Next(1000),random.Next(1000),random.Next(1,10)),
                new Tank("tank","2",random.Next(1000),random.Next(),random.Next(),random.Next(1000)),
                new AirDefenseVehicle("AirDefenseVehicle","2",random.Next(1000),random.Next(1000),random.Next(1000),random.Next(1,10)),
                new ArmoredCar("ArmoredCar","5",random.Next(1000),random.Next(1000),random.Next(1000)),
                new Tank("tank","3",random.Next(1000),random.Next(1000),random.Next(1000),random.Next(1000))
            };

            CombatVehicle[] army2 =
            {
                new ArmoredCar("ArmoredCar","40",random.Next(1000),random.Next(1000),random.Next(1000)),
                new AirDefenseVehicle("AirDefenseVehicle","20",random.Next(1000),random.Next(1000),random.Next(1000),random.Next(1,10)),
                new Tank("tank","10",random.Next(1000),random.Next(1000),random.Next(1000),random.Next(1000)),
                new ArmoredCar("ArmoredCar","50",random.Next(1000),random.Next(1000),random.Next(1000)),
                new Tank("tank","20",random.Next(1000),random.Next(1000),random.Next(1000),random.Next(1000)),
                new AirDefenseVehicle("AirDefenseVehicle","10",random.Next(1000),random.Next(1000),random.Next(1000),random.Next(1,10)),
                new Tank("tank","30",random.Next(1000),random.Next(1000),random.Next(1000),random.Next(1000))
            };

            bool viner;
            int viner1 = 0;
            int viner2 = 0;

            for (int i = 0; i < army1.Length*2; i++)
            {
                viner = Round(army1[random.Next(0, army1.Length)], army2[random.Next(0, army1.Length)]);
                if (viner)
                {
                    viner1++;
                }
                else
                {
                    viner2++; 
                }
            }

            if (viner1>viner2)
            {
                Console.WriteLine("army1 win");
            }
            else 
            {
                Console.WriteLine("army2 win");
            }

            for (int i = 0; i < army1.Length; i++)
            {
                Console.WriteLine($"army1[{i}] is restroyed {army1[i].IsDestroyed()}");
            }
            Console.WriteLine("----------------");
            for (int i = 0; i < army1.Length; i++)
            {
                Console.WriteLine($"army2[{i}] is restroyed {army2[i].IsDestroyed()}");
            }

        }
    }
}