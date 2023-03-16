using System;

    class Program{
        static void Main(string[] args){
            int[] numbers = new int[20];
            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++){
                numbers[i] = random.Next(1, 100);
            }
            /*Array output
            Console.WriteLine("Array filled with random numbers:");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            } */
            Console.WriteLine("1. Calculate the amount of numbers in the array");
            Console.WriteLine("2. Sort the array");
            Console.WriteLine("3. Find the number of paired values");
            Console.WriteLine("4. Find the maximum element");
            Console.WriteLine("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice){
                case 1:
                    int sum = 0;
                    foreach (int number in numbers){
                        sum += number;
                    }
                    Console.WriteLine("The amount numbers is: " + sum);
                    break;
                case 2:
                    Array.Sort(numbers);
                    Console.WriteLine("The sorted array is: ");
                    foreach (int number in numbers){
                        Console.Write(number + " ");
                    }
                    Console.WriteLine();
                    break;
                case 3:
                    int pairedCount = 0;
                    foreach (int number in numbers){
                        if (number % 2 == 0)
                        {
                            pairedCount++;
                        }
                    }
                    Console.WriteLine("The number of paired values is: " + pairedCount);
                    break;
                case 4:
                    int max = numbers[0];
                    foreach (int number in numbers){
                        if (number > max)
                        {
                            max = number;
                        }
                    }
                    Console.WriteLine("The maximum element is: " + max);
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }
        }
    }

