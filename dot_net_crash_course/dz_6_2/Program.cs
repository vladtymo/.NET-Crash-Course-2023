using System.Text;

namespace dz_6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rocket[] r1 = { new Rocket(), new Rocket("Falcon", 10, null), new Rocket("Rorshah-9", 25, "Mars") };

            foreach (Rocket r in r1)
            {
                r.ShowRocketInfo();

                r.FlyTo("Omicron-Persey");
                r.FlyTo("Venus");
                r.ShowFuelInfo();
                r.FlyTo("Mars");

                r.ShowFuelInfo();
                r.Refuel();
                r.ShowFuelInfo();

                r.FlyTo();
                r.FlyTo("Saturn");
                r.ShowTravelMap();

                Console.WriteLine("\n\n");
            }

        }
    }

    class Rocket
    {
        readonly string? rocketName;
        readonly int maxFuelLevel;
        int fuelLevel;
        string rocketLocation;
        const string defaultRocketLocation = "Earth";
        List<string> planetList = new List<string>();

        public void FlyTo(string rl = defaultRocketLocation)
        {
            if ((fuelLevel - rl.Length) < 0)
            {
                Console.WriteLine($"Not enough fuel for space travel by route \"{rocketLocation} -> {rl}\".");
            }
            else
            {
                Console.WriteLine($"Space travel by route \"{rocketLocation} -> {rl}\" is completed!");
                fuelLevel -= rl.Length;
                planetList.Add(" -> " + rl);
                rocketLocation = rl;
            }
        }

        public void ShowTravelMap()
        {
            Console.WriteLine($"Your travel map:\n{planetList}");
        }

        public void ShowRocketInfo()
        {
            Console.WriteLine($"{new string('-', 10)}\n" +
                              $"Name {(rocketName == null ? "noName" : rocketName)}\n" +
                              $"Current location: {rocketLocation}\n" +
                              $"Fuel: {fuelLevel}/{maxFuelLevel}\n" +
                              $"{new string('-', 10)}");
        }

        public void ShowFuelInfo()
        {
            Console.WriteLine($"Fuel level: {new string('+', fuelLevel)}{new string('-', (maxFuelLevel - fuelLevel))}");
        }

        public void Refuel()
        {
            Console.WriteLine("The rocket is fueled!");
            fuelLevel = maxFuelLevel;
        }

        public Rocket(string? rN, int mFL, string? rL)
        {
            rocketName = rN;
            maxFuelLevel = mFL;
            fuelLevel = maxFuelLevel;
            rocketLocation = rL ?? defaultRocketLocation;
            planetList.Append(rocketLocation);
        }

        public Rocket()
        {
            rocketLocation = defaultRocketLocation;
            planetList.Append(defaultRocketLocation);
            maxFuelLevel = 20;
            fuelLevel = maxFuelLevel;
        }

    }
}
