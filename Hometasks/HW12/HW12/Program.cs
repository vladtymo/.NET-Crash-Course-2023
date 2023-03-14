namespace HW12
{
    internal class Program
    {
        bool Round(CombatVehicle cv1, CombatVehicle cv2)
        {
            while(!cv1.isDestroyed() && !cv2.isDestroyed())
                cv2.Defense(cv1.Attack()); cv1.Defense(cv2.Attack());
            if(cv1.isDestroyed())
                return false;
            else 
                return true;
        }

        void Battle(List<CombatVehicle> army1, List<CombatVehicle> army2)
        {
            Console.WriteLine("------------ Battle started! ------------");
            int r = 0;
            while (army1.Count > 0 && army2.Count > 0) 
            {
                int l;
                if (army1.Count < army2.Count) l = army1.Count;
                else l = army2.Count;
                for(int i = 0; i < l; i++) 
                {
                    r++;
                    Console.WriteLine($"Round {r} started!");
                    if (Round(army1[i], army2[i]))
                    {
                        army2.RemoveAt(i);
                        Console.WriteLine($"Army 1 got a winner in round {r}!");
                    }
                    else
                    {
                        army1.RemoveAt(i);
                        Console.WriteLine($"Army 2 got a winner in round {r}!");
                    }
                    l--;
                }
            }
            if(army1.Count > army2.Count)
                Console.WriteLine("Army 1 won!");
            else if(army1.Count < army2.Count)
                Console.WriteLine("Army 2 won!");
            else
                Console.WriteLine("Draw!");
        }

        static void Main(string[] args)
        {
            Program P = new Program();
            List<CombatVehicle> army1 = new()
            {
                new Tank("Tiger II", 1800, 7, 0.8, 5),
                new ArmoredCar(2000, 8, 100),
                new AirDefenseVehicle(1200, 1000, 6, 5),
                new Tank(2000, 8, 0.6, 7),
                new ArmoredCar(1750, 10, 120),
                new AirDefenseVehicle(1400, 900, 7, 3)
            };
            List<CombatVehicle> army2 = new()
            {
                new Tank(2000, 8, 0.6, 7),
                new ArmoredCar(1750, 10, 120),
                new AirDefenseVehicle(1400, 900, 7, 3),
                new Tank("Tiger II", 1800, 7, 0.8, 5),
                new ArmoredCar(2000, 8, 100),
                new AirDefenseVehicle(1200, 1000, 6, 5)
            };
            P.Battle(army1, army2);
        }
    }
}