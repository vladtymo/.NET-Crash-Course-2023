using System.ComponentModel.DataAnnotations;

namespace Task3
{
    public static class Solutions
    {
        private static int _secterNumber;

        private static int IntValidator()
        {
            if (!int.TryParse(Console.ReadLine(), out int result))
            {
                Console.Write("Invalid value. Try again: ");
                while (!int.TryParse(Console.ReadLine(), out result))
                {
                    Console.Write("Invalid value. Try again: ");
                }
            }
            return result;
        }

        private static uint UIntValidator()
        {
            if (!uint.TryParse(Console.ReadLine(), out uint result))
            {
                Console.Write("Invalid value. Try again: ");
                while (!uint.TryParse(Console.ReadLine(), out result))
                {
                    Console.Write("Invalid value. Try again: ");
                }
            }
            return result;
        }

        private static int EnumValidation(Type enumType)
        {
            if (!int.TryParse(Console.ReadLine(), out int result) ||
                !Enum.IsDefined(enumType, result))
            {
                Console.Write("Invalid value. Try again: ");
                while (!int.TryParse(Console.ReadLine(), out result) ||
                    !Enum.IsDefined(enumType, result))
                {
                    Console.Write("Invalid value. Try again: ");
                }
            }
            return result;
        }

        private static void PrintArray(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "\t");
            }
            Console.WriteLine();
        }

        private static void PrintArray(int[,] array)
        {
            for(int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        private enum Actions
        {
            [Display(Name = "Get sum")]
            GetSum = 1,

            [Display(Name = "Sort array")]
            SortArray = 2,

            [Display(Name = "Sort array by columns")]
            SortByColumns = 3,

            [Display(Name = "Sort array by rows")]
            SortByRows = 4,

            [Display(Name = "Get number of even numbers")]
            NumberOfEvenNumbers = 5,

            [Display(Name = "GetMaxValue")]
            GetMaxValue = 6,
        }

        // Draw line
        public static void Exercise1()
        {
            Console.Write("Line length: ");
            if (!int.TryParse(Console.ReadLine(), out int length))
            {
                Console.Write("Invalid value. Try again: ");
                while (!int.TryParse(Console.ReadLine(), out length))
                {
                    Console.Write("Invalid value. Try again: ");
                }
            }

            Console.Write("Press symbol to draw the line: ");
            var key = Console.ReadKey();
            Console.WriteLine();
            
            while (key.KeyChar < 33 || key.KeyChar > 126)
            {
                Console.Write("Incorrect symbol. Try again: ");
                key = Console.ReadKey();
            }

            for(int i = 0; i < length; i++)
            {
                Console.Write(key.KeyChar);
            }
        }

        // Guess number
        public static void Exercise2()
        {
            Console.Write("Lower border of secret number: ");
            int lowerBorder = IntValidator();

            Console.Write("Upper border of secret number: ");
            int upperBorder = IntValidator();

            _secterNumber = new Random().Next(lowerBorder, upperBorder);
            Console.Write("Press your value: ");
            int userValue = IntValidator();

            while(userValue != _secterNumber)
            {
                Console.Write("You didn't guess. ");
                if (userValue > _secterNumber)
                {
                    Console.Write("Your number is greater than secret number. ");
                }
                else
                {
                    Console.Write("Your number is less than secret number. ");
                }
                Console.Write("Try again: ");
                
                userValue = IntValidator();
            }
            Console.WriteLine("Congratulation!");
        }

        // One-dimension array
        public static void Exercise3_1()
        {
            Console.Write("Array length: ");
            int length = IntValidator();

            Console.Write("Lower border of random: ");
            int lowerBorder = IntValidator();

            Console.Write("Upper border of random: ");
            int upperBorder = IntValidator();

            int[] array = new int[length];
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(lowerBorder, upperBorder);
            }
            PrintArray(array);


            Console.WriteLine($"{Actions.GetSum} - 1");
            Console.WriteLine($"{Actions.SortArray} - 2");
            Console.WriteLine($"{Actions.NumberOfEvenNumbers} - 5");
            Console.WriteLine($"{Actions.GetMaxValue} - 6");
            Console.Write("Choose the action: ");
            int action = EnumValidation(typeof(Actions));

            switch((Actions)action) 
            {
                case Actions.GetSum: // 1
                    {
                        Console.WriteLine("Sum of element of array: " + array.Sum());
                        break;
                    }
                case Actions.SortArray: // 2
                    {
                        Array.Sort(array);
                        PrintArray(array);
                        break;
                    }
                case Actions.NumberOfEvenNumbers: // 3
                    {
                        int counter = 0;
                        for(int i = 0; i < array.Length; i++)
                        {
                            if (array[i] % 2 == 0)
                            {
                                counter++;
                            }
                        }
                        Console.WriteLine("Number of event number: " + counter);

                        break;
                    }
                case Actions.GetMaxValue: // 4
                    {
                        int maxValue = array[0];
                        for(int i = 0; i < array.Length; i++)
                        {
                            if (array[i] > maxValue)
                            {
                                maxValue = array[i];
                            }
                        }
                        Console.WriteLine("Max value: " + maxValue);

                        break;
                    }
                default:
                    {
                        throw new Exception($"Choose other action");
                    }
            }
        }
        
        // Two-dimension array
        public static void Exercise3_2()
        {
            Console.Write("Matrix height: ");
            int height = IntValidator();

            Console.Write("Matrix length: ");
            int length = IntValidator();

            Console.Write("Lower border of random: ");
            int lowerBorder = IntValidator();

            Console.Write("Upper border of random: ");
            int upperBorder = IntValidator();

            int[,] twoDimensionArray = new int[height, length];
            for(int i = 0; i < twoDimensionArray.GetLength(0); i++)
            {
                for(int j = 0; j < twoDimensionArray.GetLength(1); j++)
                {
                    twoDimensionArray[i, j] = new Random().Next(lowerBorder, upperBorder);
                }
            }

            PrintArray(twoDimensionArray);
            Console.WriteLine();

            foreach(int i in Enum.GetValues(typeof(Actions)))
            {
                if(i != 2)
                {
                    Console.WriteLine($"{(Actions)i}: {i}");
                }
            }
            Console.Write("Choose action: ");
            int action = EnumValidation(typeof(Actions));

            switch((Actions)action)
            {
                case Actions.GetSum:
                    {
                        int sum = 0;
                        for(int i = 0; i < twoDimensionArray.GetLength(0); i++)
                        {
                            for(int j = 0; j < twoDimensionArray.GetLength(1); j++)
                            {
                                sum += twoDimensionArray[i, j];
                            }
                        }
                        Console.WriteLine("Sum = " + sum);

                        break;
                    }
                case Actions.SortByColumns:
                    {
                        for(int j = 0; j < twoDimensionArray.GetLength(1); j++)
                        {
                            int[] column = new int[twoDimensionArray.GetLength(0)];
                            for(int i = 0; i < twoDimensionArray.GetLength(0); i++)
                            {
                                column[i] = twoDimensionArray[i, j];
                            }
                            Array.Sort(column);

                            for(int i = 0; i < twoDimensionArray.GetLength(0); i++)
                            {
                                twoDimensionArray[i, j] = column[i];
                            }
                        }
                        PrintArray(twoDimensionArray);

                        break;
                    }
                case Actions.SortByRows:
                    {
                        for(int i = 0; i < twoDimensionArray.GetLength(0); i++)
                        {
                            int[] row = new int[twoDimensionArray.GetLength(1)];
                            for(int j = 0; j < twoDimensionArray.GetLength(1); j++)
                            {
                                row[j] = twoDimensionArray[i, j];
                            }
                            Array.Sort(row);

                            for(int j = 0; j < twoDimensionArray.GetLength(1); j++)
                            {
                                twoDimensionArray[i, j] = row[j];
                            }
                        }
                        PrintArray(twoDimensionArray);

                        break;
                    }
                case Actions.NumberOfEvenNumbers:
                    {
                        int counter = 0;
                        for(int i = 0; i < twoDimensionArray.GetLength(0); i++)
                        {
                            for(int j = 0; j < twoDimensionArray.GetLength(1); j++)
                            {
                                if (twoDimensionArray[i, j] % 2 == 0)
                                {
                                    counter++;
                                }
                            }
                        }
                        Console.WriteLine("Number of even numbers: " + counter);

                        break;
                    }
                case Actions.GetMaxValue:
                    {
                        int maxValiue = twoDimensionArray[0, 0];
                        for(int i = 0; i < twoDimensionArray.GetLength(0); i++)
                        {
                            for(int j = 0; j < twoDimensionArray.GetLength(1); j++)
                            {
                                if (twoDimensionArray[i, j] > maxValiue)
                                {
                                    maxValiue = twoDimensionArray[i, j];
                                }
                            }
                        }
                        Console.WriteLine("Max value: " + maxValiue);

                        break;
                    }
            }
        }

        // Array of array
        public static void Exercise3_3()
        {
            Console.Write("Array total length: ");
            int totalLength = IntValidator();

            Console.Write("Lower border of random: ");
            int lowerBorder = IntValidator();

            Console.Write("Upper border of random: ");
            int upperBorder = IntValidator();

            int[][] arrayOfArray = new int[totalLength][];
            for(int i = 0; i < arrayOfArray.Length; i++)
            {
                arrayOfArray[i] = new int[new Random().Next(totalLength / 2, totalLength)];

                for(int j = 0; j < arrayOfArray[i].Length; j++)
                {
                    arrayOfArray[i][j] = new Random().Next(lowerBorder, upperBorder);
                }

                PrintArray(arrayOfArray[i]);
            }

            foreach (int i in Enum.GetValues(typeof(Actions)))
            {
                if (i != 3 && i != 4)
                {
                    Console.WriteLine($"{(Actions)i}: {i}");
                }
            }
            Console.Write("Choose action: ");
            int action = EnumValidation(typeof(Actions));

            switch((Actions)action)
            {
                case Actions.GetSum:
                    {
                        int sum = 0;
                        for(int i = 0; i < arrayOfArray.Length; i++)
                        {
                            sum += arrayOfArray[i].Sum();
                        }
                        Console.WriteLine("Sum: " + sum);

                        break;
                    }
                case Actions.SortArray:
                    {
                        for(int i = 0; i < arrayOfArray.Length; i++)
                        {
                            Array.Sort(arrayOfArray[i]);
                            PrintArray(arrayOfArray[i]);
                        }

                        break;
                    }
                case Actions.NumberOfEvenNumbers:
                    {
                        int counter = 0;
                        for(int i = 0; i < arrayOfArray.Length; i++)
                        {
                            counter += arrayOfArray[i].Where(item => item % 2 == 0).Count();
                        }
                        Console.WriteLine("Number of even numbers: " + counter);

                        break;
                    }
                case Actions.GetMaxValue:
                    {
                        int maxValue = 0;
                        for(int i = 0; i < arrayOfArray.Length; i++)
                        {
                            for(int j = 0; j < arrayOfArray[i].Length; j++)
                            {
                                if(arrayOfArray[i][j] > maxValue)
                                {
                                    maxValue = arrayOfArray[i][j];
                                }
                            }
                        }
                        Console.WriteLine("Max value: " + maxValue);

                        break;
                    }
            }
        }

        // Append item by index
        public static void Exercise4()
        {
            Console.Write("Array length: ");
            int length = IntValidator();

            Console.Write("Lower border of random: ");
            int lower = IntValidator();

            Console.Write("Upper border of random: ");
            int upper = IntValidator();

            int[] array = new int[length];
            for(int i = 0; i < length; i++) 
                array[i] = new Random().Next(lower, upper);
            PrintArray(array);

            Console.Write("Index: ");
            uint index = UIntValidator();

            Console.Write("Item value: ");
            int value = IntValidator();

            int[] copyArray = new int[length + 1];
            int counter = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if(i == index)
                {
                    copyArray[counter] = value;
                    counter++;
                }

                copyArray[counter] = array[i];
                counter++;
            }

            PrintArray(copyArray);
        }

        // Delete item by index
        public static void Exercise5()
        {
            Console.Write("Array length: ");
            int length = IntValidator();

            Console.Write("Lower border of random: ");
            int lower = IntValidator();

            Console.Write("Upper border of random: ");
            int upper = IntValidator();

            int[] array = new int[length];
            for (int i = 0; i < length; i++)
                array[i] = new Random().Next(lower, upper);
            PrintArray(array);

            Console.Write("Delete index: ");
            uint index = UIntValidator();

            int[] copyArray = new int[length - 1];
            int counter = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if(i == index)
                {
                    continue;
                }
                copyArray[counter] = array[i];
                counter++;
            }

            PrintArray(copyArray);
        }

        // Delete items by value
        public static void Exercise6()
        {
            Console.Write("Array length: ");
            int length = IntValidator();

            Console.Write("Lower border of random: ");
            int lower = IntValidator();

            Console.Write("Upper border of random: ");
            int upper = IntValidator();

            int[] array = new int[length];
            for (int i = 0; i < length; i++)
                array[i] = new Random().Next(lower, upper);
            PrintArray(array);

            Console.Write("Delete value: ");
            int value = IntValidator();
            int[] copyArray = new int[0];

            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] != value)
                {
                    Array.Resize(ref copyArray, copyArray.Length + 1);
                    copyArray[copyArray.Length - 1] = array[i];
                }
            }

            PrintArray(copyArray);
        }
    }
}