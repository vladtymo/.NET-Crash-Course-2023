namespace _14_DelegatesInitializer
{
    internal class Program
    {
         public delegate int ArrayVolume(int index);
         public static void Initialization(int[] array, ArrayVolume volume)
         {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = volume(i);
            }
         }

        public static void Main()
        {
            Random randomValue = new Random();
            Console.WriteLine("Task 1 ");
            int[] randomArray = new int[15];
            Initialization(randomArray, index => randomValue.Next(1, 100));
            Console.WriteLine("Random array:");
            foreach (int el in randomArray)
            {
                Console.Write($"{el}  ");
            }
            Console.WriteLine();

            Console.WriteLine("\nTask 2 ");
            int[] powerOfTwoArray = new int[10];
            Initialization(powerOfTwoArray, index => (int)Math.Pow(2, index));
            Console.WriteLine("Power of two array:");
            foreach (int el in powerOfTwoArray)
            {
                Console.Write($"{el}  ");
            }
            Console.WriteLine();
            Console.WriteLine("\nTask 3 ");
            int[] stepIncreaseByTreeArray = new int[20];
            Initialization(stepIncreaseByTreeArray, index => index + 3);
            Console.WriteLine("Step increase by tree array:");
            foreach (int el in stepIncreaseByTreeArray)
            {
                Console.Write($"{el}  ");
            }
            Console.WriteLine();
            Console.WriteLine("\nTask 4 ");
            int[] fibonacciArray = new int[10];
            Initialization(fibonacciArray, index => index < 2 ? index : fibonacciArray[index - 1] + fibonacciArray[index - 2]);
            Console.WriteLine("Fibonacci array:");
            foreach (int el in fibonacciArray)
            {
                Console.Write($"{el}  ");
            }
            Console.WriteLine();


        }
    }
}
