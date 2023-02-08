enum Menu { Suma = 1,Sort,Even_numbers,Max_Value};

internal class task_randomize_array
{
    private static void Main(string[] args)
    {
        Random random = new Random();
        int[] array = new int[20];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next()%101;
        }
        Console.Write("array = {");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]+" ");
        }
        Console.Write("}\n");
        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
        Menu menuValue =Menu.Suma;
        while (menuValue!=0)
        {
        Console.WriteLine("Choose function:\n"+
                          $"{(int)Menu.Suma}  -  {Menu.Suma} \n" +
                          $"{(int)Menu.Sort}  -  {Menu.Sort} \n" +
                          $"{(int)Menu.Even_numbers}  -  {Menu.Even_numbers} \n" +
                          $"{(int)Menu.Max_Value}  -  {Menu.Max_Value} \n" +
                          "0  -  Exit\n");
        menuValue = Enum.Parse<Menu>(Console.ReadLine());
            switch (menuValue)
            {
                case Menu.Suma:
                    {
                        int sum =0;
                        for (int i = 0; i < array.Length; i++)
                        {
                            sum+=array[i];
                        }
                        Console.WriteLine($"Suma = {sum}");
                        }
                    break;
                case Menu.Sort:
                    Array.Sort(array);
                    Console.Write("array = {");
                    for (int i = 0; i < array.Length; i++)Console.Write(array[i] + " ");
                    Console.Write("}\n");
                    break;
                case Menu.Even_numbers:
                    int even_number = 0;
                    for (int i = 0; i < array.Length; i++)if(array[i]%2==0)even_number++;
                    Console.WriteLine($"Even numbers: {even_number}");
                    break;
                case Menu.Max_Value:
                    int max=array[0];
                    for (int i = 1; i < array.Length; i++)
                    {
                        if(array[i]>=max)max=array[i];
                    }
                    Console.WriteLine($"Max Value = {max}");
                    break;
                default:
                    Console.WriteLine("Goodbye!!!");
                    break;
            }

        }




    }
}