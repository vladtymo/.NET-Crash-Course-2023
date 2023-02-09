using System.Xml.Schema;

namespace Tasks_3
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Завдання:
            //1. Показати лінію на екран. Символ та довжину лінії повинен вводити користувач.
            Console.WriteLine("Task 1");
            Task1("_", 1000);
            //2. Написати гру «Вгадай число». Програма «загадує» випадковим чином число, після чого користувач повинен вгадати його.
            //Вкінці потрібнго відобразити кількість спроб, яку було використано.
            Console.WriteLine("Task 2");
            //  Task2();
            //3. Створити масив із 20-ти цілих чисел та заповнити його випадковими значеннями від 0 до 100.
            Console.WriteLine("Task 3");
            int[] arr = new int[20];
            //  Task3(arr);
            //4. До попереднього завдання додати меню, яке дозволить користувачу виконати наступне:
            Console.WriteLine("Task 4");
            Task4();
              /* - обрахувати суму чисел в масиві
               - відсортувати масив
               - знайти кількість парних значень
               - *знайти максимальний елемент
              */
           

            Console.ReadKey();
        }
        static void Task1(string symbol, int lenght)
        {
            for(int i=0; i<lenght; i++)
            {
                Console.Write(symbol);
            }Console.WriteLine();
        } 
        static void Task2()
        {
            Random random = new Random();
            int winningNum = random.Next(1,101), myNum=0,counter=0;
            Console.WriteLine("You have to guess which number is guessed from 1 to 100.\n If you enter \"-1\" the game ends.\nGood Luck!");
            
            
            do
            {
               
                Console.Write("Enter your num: ");
                myNum = int.Parse(Console.ReadLine());
               
                if (myNum < -1 || myNum > 100)
                {
                    Console.WriteLine("Enter a valid value (from 1 to 100)");
                }
                
                else
                {
                    ++counter;
                    if (myNum == -1)
                    {
                       Console.WriteLine($"The number was {winningNum}");
                        Console.WriteLine($"Game Over");
                        break;
                    }
                    else if (myNum > winningNum)
                    {
                        Console.WriteLine("The winning number is smaller then your.");

                    }
                    else if (myNum < winningNum)
                    {
                        Console.WriteLine("The winning number is bigger then your.");

                    }
                    else
                    {

                        Console.WriteLine("Congratulations!");
                        Console.WriteLine($"You have made {counter} attempts!");
                        break;
                    }
                }
            } while (true);

        }
        static void Task3(int[] arr )
        {
            Random random = new Random();
          
            for(int i=0;i<arr.Length;i++) arr[i] = random.Next(0, 100);
            Console.Write("Arr elements: "); 
            Print(arr);
           
            
        }
        
        enum Calculations { Sum=1 ,Sort, NumOfEven , FindMax }
   
        static void Task4()
        {
           
            int[] arr = new int[5];
            int count=0,sum=0;
            Task3(arr);
            Console.WriteLine($" Select which array action you want to perform: \n" +
                $"{(int)Calculations.Sum}- calculate the sum of the numbers in the array\n" +
                $"{(int)Calculations.Sort}- sort the array\n" +
                $"{(int)Calculations.NumOfEven}- find the number of even values\n" +
                $"{(int)Calculations.FindMax}- find the maximum element" 
                );
           
            Console.Write("Enter your choice: ");
            Calculations calculations = Enum.Parse<Calculations>(Console.ReadLine());
            switch(calculations)
            {
                case Calculations.Sum:
                    for (int i = 0; i < arr.Length; i++)
                            sum += arr[i];
                    Console.WriteLine("Sum = "+ sum);
                    break;
                case Calculations.Sort:
                    Array.Sort(arr);
                    Console.Write("After sort :");
                    Print(arr);
                    break;
                case Calculations.NumOfEven:
                    foreach (int e in arr)
                        if (e % 2 == 0)
                            ++count;
                    Console.WriteLine($"Number of even numbers = {count}.");
                    break;
                case Calculations.FindMax:

                    Console.Write("Max value in array is: "); Print(arr.Max()); 

                   // int[] arr2 = new int[arr.Length];
                   // Array.Copy(arr, arr2, arr.Length);        
                   // Array.Sort(arr2);
                   //Print(arr2[arr2.Length - 1]);

                    break;
              
            }
        }
        static void Print(params int[] arr)
        {
            foreach(int e in arr)
            {
                Console.Write(e + " ");
            }
            Console.WriteLine();
        }
    }
}