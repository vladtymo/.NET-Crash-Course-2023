namespace _12_structures
{
    class TimeClass // can inherite a single class
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public TimeClass(int hours, int minutes)
        {
            Hours = hours >= 0 ? hours : 0;
            Minutes = minutes >= 0 ? minutes : 0;
        }

        public override string ToString()
        {
            return $"Time: {Hours}:{Minutes}";
        }
    }

    struct TimeStruct // cannot inherite 
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }

        public TimeStruct(int hours, int minutes)
        {
            Hours = hours >= 0 ? hours : 0;
            Minutes = minutes >= 0 ? minutes : 0;
        }

        public override string ToString()
        {
            return $"Time: {Hours}:{Minutes}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // nullable types
            TimeClass? emptyObj = null;
            TimeStruct? emptyStruct = null;

            // ------------- class
            TimeClass timeClass;                // create null reference
            timeClass = new TimeClass(35, 10);  // allocate memory and invoke constructor

            Console.WriteLine(timeClass);

            // ------------- struct
            TimeStruct timeStruct;                // allocate memory
            timeStruct = new TimeStruct(35, 10);  // invoke constructor

            Console.WriteLine(timeStruct);
        }
    }
}