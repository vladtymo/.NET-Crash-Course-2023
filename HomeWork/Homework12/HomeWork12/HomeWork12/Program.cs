namespace HomeWork12
{
    internal class Program
    {
        public static void InitializeArray(int[] arr, Func<int, int> initializer)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = initializer(i);
            }
        }
        static void Main(string[] args)
        {
            int[] array1 = new int[15];
            InitializeArray(array1, i => new Random().Next(1, 100));

            int[] array2 = new int[10];
            InitializeArray(array2, (i) => i == 0 ? 2 : (int)Math.Pow(2, i));


            int[] array3 = new int[20];
            InitializeArray(array3, i => i * 3);

            Console.WriteLine("Array 1: " + string.Join(", ", array1));
            Console.WriteLine("Array 2: " + string.Join(", ", array2));
            Console.WriteLine("Array 3: " + string.Join(", ", array3));
        }


    }

}