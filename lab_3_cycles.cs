internal class lab_3_cycles
{
    enum MenuArray { SumOfAllElements = 1, ArraySorting,NumberOfEven,MaximumValue };

    static void Main(string[] args)
    {
        Console.WriteLine("Task 1");
        Console.WriteLine("Enter the length of the line:");
        int lenght = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter a character fot the line:");
        char character=Convert.ToChar(Console.ReadLine());
        while(lenght!=0)
        {
            Console.Write($"{character}");
            --lenght;
        }
        Console.WriteLine();

        Console.WriteLine("Task 2");
        Random rnd = new Random();
        int randomNumber = rnd.Next(1,10);  //number from 1 to 10
        int counter = 0;
        int yourNumber=-1;
        while(yourNumber!=randomNumber)
        {
            Console.WriteLine("Try to guess the number:");
            yourNumber = Convert.ToInt32(Console.ReadLine());
            ++counter;
            if (yourNumber != randomNumber)
            {
                Console.WriteLine("You didn`t guess!");
                if (yourNumber > randomNumber) Console.WriteLine($"{yourNumber} > riddled number!!!");
                else if (yourNumber < randomNumber) Console.WriteLine($"{yourNumber} < riddled number!!!");
            }
        }
        Console.WriteLine($"{counter} trainse were used");
        Console.WriteLine();

        Console.WriteLine("Task 3");
        const int size = 20;
        int[] array = new int[size];
        for(int i=0;i<array.Length;++i)
        {
            int newRandomNmber = rnd.Next(0, 100);
            array[i] = newRandomNmber;
        }
        foreach(int el in array)
        {
            Console.Write($"{el} ");
        }
        Console.WriteLine();

        Console.WriteLine("Task 4");
        int k = 5;
        while (k != 0)
        {
            --k;
            Console.Write("\nChoose the action:" +
               $"\n{(int)MenuArray.SumOfAllElements}-{MenuArray.SumOfAllElements}" +
               $"\n{(int)MenuArray.ArraySorting}-{MenuArray.ArraySorting}" +
               $"\n{(int)MenuArray.NumberOfEven} - {MenuArray.NumberOfEven}" +
               $"\n{(int)MenuArray.MaximumValue}-{MenuArray.MaximumValue}\n");
            MenuArray yourChoise = Enum.Parse<MenuArray>(Console.ReadLine());
            Console.WriteLine();
            switch (yourChoise)
            {
                case MenuArray.SumOfAllElements:
                    {
                        int sumOfALL = 0;
                        for (int i = 0; i < array.Length; ++i)
                        {
                            sumOfALL += array[i];
                        }
                        Console.WriteLine($"Suma of all elements in array ={sumOfALL}");
                    }
                    break;
                case MenuArray.ArraySorting:
                    {
                        Array.Sort(array);
                        foreach (int el in array)
                        {
                            Console.Write($"{el} ");
                        }
                        Console.WriteLine();
                    }
                    break;
                case MenuArray.NumberOfEven:
                    {
                        int count = 0;
                        for (int i = 0; i < array.Length; ++i)
                        {
                            if (array[i] % 2 == 0) ++count;
                        }
                        Console.WriteLine($"The number of even ={count}");
                    }
                    break;
                case MenuArray.MaximumValue:
                    {
                        int maxValue = array[0];
                        for (int i = 1; i < array.Length; ++i)
                        {
                            if (maxValue < array[i]) maxValue = array[i];
                        }
                        Console.WriteLine($"Maximum value = {maxValue}, in position {Array.IndexOf(array, maxValue)}.");
                    }
                    break;
                default: Console.WriteLine("\nInvalid value!"); break;
            }

        }
    }

}