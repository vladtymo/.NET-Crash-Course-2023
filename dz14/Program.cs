internal class Program
{
    public static int[] InitializeArray(int size, Func<int, int> generator)
    {
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = generator(i);
        }
        return array;
    }
    public static void ShowArr(int size, int[] arr){
        for(int i = 0;i<size;i++){
            System.Console.Write(arr[i] + " ");
        }
        System.Console.WriteLine();
    }
    private static void Main(string[] args)
    {
        int[] arr1 = InitializeArray(15, (i) => new Random().Next(1, 101));
        int[] arr2 = InitializeArray(10, (i) => (int)Math.Pow(2,i+1));
        int[] arr3 = InitializeArray(20, (i) => 3*i);
        int[] arr4 = InitializeArray(10, (i) => {
            int a = 0;
            int b = 1;
            int j = i;
            while(j!=0){
                int c = a+b;
                a = b;
                b = c;
                --j;
            }
            return a;
        });
        ShowArr(15,arr1);
        ShowArr(10,arr2);
        ShowArr(20,arr3);
        ShowArr(10,arr4);



    }
}