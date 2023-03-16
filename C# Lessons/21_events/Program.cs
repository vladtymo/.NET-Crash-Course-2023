using System.Xml.Serialization;

namespace _21_events
{
    class Human
    {
        public string Name { get; set; }
        public event Action WorkProcesses;

        public void DoWork()
        {
            Console.WriteLine($"I am {Name}. I am doing my work...");
            // .? - if delegate is not null
            WorkProcesses?.Invoke();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human = new()
            {
                Name = "Emannuel"
            };
            human.WorkProcesses += () => Console.WriteLine("Walking around...");
            human.WorkProcesses += () => Console.WriteLine("Writing code in C#");
            human.WorkProcesses += () => Console.WriteLine("Eating food and drinking");

            human.WorkProcesses += Programming;
            human.WorkProcesses -= Programming;

            // event incapsulates all of the members except [+=] [-=] operators
            //human.WorkProcesses = null;

            human.DoWork();
        }

        private static void Programming()
        {
            Console.WriteLine("Creating application");
        }
    }
}