namespace Task14Delegates
{
    internal class Program
    {
        static void InitArr(int[] arr, Func<int, int> func)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = func.Invoke(i);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            //1
            int[] arr1 = new int[15];
            Random random = new Random();
            InitArr(arr1,(i)=> random.Next(1,100));

            //2
            int[] arr2 = new int[10];
            InitArr(arr2, (i) => i == 0 ? 2 : arr2[i - 1] * 2);

            //3
            int[] arr3 = new int[20];
            InitArr(arr3, (i) => i == 0 ? 0 : arr3[i - 1] + 3);

            //4
            int[] arr4 = new int[10];
            InitArr(arr4, (i) => i == 0 ? 0 : i == 1 ? 1 : (arr4[i-1]) + arr4[i - 2]);
        }
    }
}