using System.Xml.Serialization;

namespace _21_events
{
    class Human
    {
        public string Name { get; set; }
        public DateOnly Birthdate { get; set; }
        public event Action WorkProcesses;
        public event Action<int> Celebrate;

        public void DoWork()
        {
            Console.WriteLine($"I am {Name}. I am doing my work...");
            // .? - if delegate is not null
            WorkProcesses?.Invoke();
        }

        public void StartCelebration()
        {
            Console.WriteLine($"{Name} is starting his celebration...");
            // notify friends
            Celebrate?.Invoke(DateTime.Now.Year - Birthdate.Year);
        }
    }

    class Friend
    {
        public string Name { get; set; }

        public void Congratulate(int age)
        {
            Console.WriteLine("Congratulation with your birthday!");

            Console.Write($"{Name} is presenting you the ");
            if (age < 18)
                Console.WriteLine("milk -:)");
            else
                Console.WriteLine("beer ))");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human = new()
            {
                Name = "Emannuel",
                Birthdate = new DateOnly(2000, 5, 8)
            };
            human.WorkProcesses += () => Console.WriteLine("Walking around...");
            human.WorkProcesses += () => Console.WriteLine("Writing code in C#");
            human.WorkProcesses += () => Console.WriteLine("Eating food and drinking");

            human.WorkProcesses += Programming;
            human.WorkProcesses -= Programming;

            // event incapsulates all of the members except [+=] [-=] operators
            //human.WorkProcesses = null;

            human.DoWork();

            Friend friend1 = new() { Name = "Kevin" };
            Friend friend2 = new() { Name = "Julia" };
            Friend friend3 = new() { Name = "Anton" };

            // subscribe
            human.Celebrate += friend1.Congratulate;
            human.Celebrate += friend2.Congratulate;
            human.Celebrate += friend3.Congratulate;

            // unsubscribe
            human.Celebrate -= friend2.Congratulate;

            human.StartCelebration();
        }

        private static void Programming()
        {
            Console.WriteLine("Creating application");
        }
    }
}