enum Operation { Sum=1,Sort,numOfPair,Max };
internal class Program {
    private static void Main(string[] args){
        //1 question
        //Console.WriteLine("Enter a length of line: ");
        //int lenght = int.Parse(Console.ReadLine());
        //Console.WriteLine("Enter your symbol: ");
        //char line=char.Parse(Console.ReadLine());
        //for(int i=0; i < lenght; i++){
        //    Console.Write(line);
        //}

        //2 question
        Random random = new Random();
        Console.WriteLine("Enter a range of randomizer" +
            "(first minimal value,then maximum): ");
        int min = int.Parse(Console.ReadLine());
        int max = int.Parse(Console.ReadLine());
        int target = random.Next(min, max);
        int counter = 0;
        int number = 0;
        while (number != target){
            Console.WriteLine("Enter your number: ");
            number = int.Parse(Console.ReadLine());
            ++counter;
            if (number != target){
                Console.WriteLine("Ooops, you miss");
            }
        }
        Console.WriteLine("Congarulation!!!\n" +
            $"You did it from {counter} attempt!");

        //3 question
        Random random_1 = new Random();
        int[] array = new int[20];
        for (int i = 0; i < array.Length; ++i){
            array[i] = random_1.Next(0,100);
            Console.Write(array[i] + "   ");   
        }

       //4 question
        Console.WriteLine("\nInput num of operation:\n" +
            "1 - sum of all array\n" +
            "2 - sort\n" +
            "3 - search number of pair numbers\n" +
            "4 - search maximum value ");
        Operation num = Enum.Parse<Operation>(Console.ReadLine());
        switch (num) { 
            case Operation.Sum:
                int sum = 0;
                for (int i = 0; i < array.Length; ++i){
                    sum += array[i];
                }
                Console.Write($"Sum of all array: {sum}");
                break;
            case Operation.Sort:
                Console.WriteLine("Before: ");
                for (int i=0;i<array.Length;++i){
                    Console.Write(array[i]+"   ");
                }
                Array.Sort(array);
                Console.WriteLine("\nAfter: ");
                for (int i = 0; i < array.Length; ++i){
                    Console.Write(array[i]+"   ");
                }
                break;
            case Operation.numOfPair:
                int nums = 0;
                for (int i = 0; i < array.Length; ++i){
                    if (array[i] % 2 == 0){
                        ++nums;
                        Console.Write(array[i] + "   ");
                    }
                }
                Console.WriteLine($"Num of pair: {nums}");
                break;
            case Operation.Max:
                int temp = 0;
                for (int i = 0; i < array.Length; ++i){
                    if (temp < array[i]){
                        temp = array[i];
                    }
                }
                Console.WriteLine($"Maximum value: {temp}");
                break;
                default:
                    Console.WriteLine("Unknown operation");
                break;
        }
    }   
}
