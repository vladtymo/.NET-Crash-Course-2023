namespace Task14
{
    internal class Program
    {
        delegate void GenerationMethod(out int[] array, int length);

        static void GenerateByOne(out int[] array, int length)
        {
            array = new int[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = i + 1;
            }
        }

        static void GenerateByPowerOfTwo(out int[] array, int length)
        {
            array = new int[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = (int)Math.Pow(2, i);
            }
        }

        static void GenerateByThree(out int[] array, int length)
        {
            array = new int[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = (i + 1) * 3;
            }
        }

        static void GenerateFibonacci(out int[] array, int length)
        {
            if (length < 2)
            {
                throw new Exception("Length must me greater than of equal 2");
            }

            array = new int[length];
            array[0] = 1;
            array[1] = 1;

            for (int i = 2; i < length; i++)
            {
                array[i] = array[i - 2] + array[i - 1];
            }
        }

        static void GenerateArray(GenerationMethod method, ref int[] array)
        {
            method(out array, array.Length);
        }

        static void PrintArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

        static void Main(string[] args)
        {
            int[] array1 = new int[15];
            GenerateArray(GenerateByOne, ref array1);
            PrintArray(array1);
            Console.WriteLine();

            int[] array2 = new int[10];
            GenerateArray(GenerateByPowerOfTwo, ref array2);
            PrintArray(array2);
            Console.WriteLine();

            int[] array3 = new int[20];
            GenerateArray(GenerateByThree, ref array3);
            PrintArray(array3);
            Console.WriteLine();

            int[] array4 = new int[10];
            GenerateArray(GenerateFibonacci, ref array4);
            PrintArray(array4);
        }
    }
}