namespace HW14
{
    internal class Program
    {
        static void InitializeArray(int[] array, Func<int> valueGenerator)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = valueGenerator();
            }
        }
        static void InitializeArray(int[] array, Func<int, int> valueGenerator)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = valueGenerator(i);
            }
        }
        static void Main(string[] args)
        {
            int[] array1 = new int[15];
            Random random = new Random();
            InitializeArray(array1, () => random.Next(1, 101));

            int[] array2 = new int[10];
            InitializeArray(array2, i => (int)Math.Pow(2, i));

            int[] array3 = new int[20];
            InitializeArray(array3, i => i * 3);

            Console.WriteLine("Array 1: " + string.Join(" ", array1));
            Console.WriteLine("Array 2: " + string.Join(" ", array2));
            Console.WriteLine("Array 3: " + string.Join(" ", array3));
        }
    }
}