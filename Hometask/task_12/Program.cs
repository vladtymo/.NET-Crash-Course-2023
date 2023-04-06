namespace task_12
{
    internal class Program
    {
        const int n = 5;
        static void Create(List<CombatVehicle> arm)
        {
            Random rand = new Random();
            for(int i=0; i<n; i++) 
            {
                int tm = rand.Next(3);

                switch (tm)
                {
                    case 0:
                        arm.Add(new Tank(rand.Next(10, 60), rand.Next(50, 100), rand.Next(50, 100), rand.Next(60, 100), $"Abrams {rand.Next(10)}"));
                        break;

                    case 1:
                        arm.Add(new ArmoredCar(rand.Next(2, 10), rand.Next(70, 120), rand.Next(20, 50), $"Jeep {rand.Next(3)}"));
                        break;
                    default:
                        arm.Add(new AirDefenseVehicle(rand.Next(1000, 2000), rand.Next(50, 100), rand.Next(10, 20), rand.Next(10, 50), $"SPS - {rand.Next(10)}"));
                        break;
                }
            }

        }
        static bool Round(CombatVehicle arm1, CombatVehicle arm2)
        {
            while (arm1.Health > 0 && arm2.Health > 0)
            {
                arm2.Defense(arm1.Attack());
                arm1.Defense(arm2.Attack());
            }
            return arm1.Health > 0 ? true : false;

        }
        static bool Battle(List<CombatVehicle> arm1, List<CombatVehicle> arm2)
        {
            while (arm1.Count > 0 && arm2.Count > 0)
            {
                if (Round(arm1[0], arm2[0]))
                    arm2.RemoveAt(0);
                else
                    arm1.RemoveAt(0);
            }
            return arm1.Count > 0  ? true : false;
        }
        static void Main(string[] args)
        {
            List<CombatVehicle> arm1 = new List<CombatVehicle>();
            List<CombatVehicle> arm2 = new List<CombatVehicle>();
            
            //CombatVehicle[] arm1 = new CombatVehicle[n];
            //CombatVehicle[] arm2 = new CombatVehicle[n];
            
            Create(arm1);
            Create(arm2);

            Console.WriteLine("\tFirst arm:");
            foreach (CombatVehicle arm in arm1) 
            {
                arm.ShowInfo();        
            }

            Console.WriteLine("\tSecond arm:");
            foreach (CombatVehicle arm in arm2)
            {
                arm.ShowInfo();
            }

            if(Battle(arm1,arm2))
                Console.WriteLine("Win first arm!!!");
            else
                Console.WriteLine("Win second arm!!!");
        }
    }
}