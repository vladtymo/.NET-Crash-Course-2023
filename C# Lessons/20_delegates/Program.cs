namespace _20_delegates
{
    // create delegate: delegate return_type name(input parameters);

    delegate void Operation(long left, long right);
    // we can use also: Action<long, long>

    delegate int ChangeValue(int value);
    // we can use also: Func<int, int>

    internal class Program
    {
        static void Add(long a, long b)
        {
            Console.WriteLine($"Result: {a} + {b} = {a + b}");
        }
        static void Divide(long a, long b)
        {
            Console.WriteLine($"Result: {a} / {b} = {a / b}");
        }
        static void ShowLine(int len)
        {
            Console.WriteLine($"Line: {new string('-', len)}");
        }

        static void ChangeArray(IList<int> numbers, ChangeValue change)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                // change element...
                numbers[i] = change.Invoke(numbers[i]);
            }
        }

        static int Negative(int value)
        {
            return value * -1;
        }

        static void ShowArray(IList<int> numbers, Action<int> show)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                show.Invoke(numbers[i]);
            }
        }

        static void Main(string[] args)
        {
            Add(4, 7);
            Divide(33, 5);
            ShowLine(10);

            //Operation operation = new Operation(Add);
            Operation operation = Add;

            // Delegate inherites MulticastDelegate
            // add methods
            operation += Divide;
            operation += (a, b) => Console.WriteLine("Result: " + (a * b));

            // remove methods
            operation -= Divide;

            operation.Invoke(5, 6);
            operation(7, 8);

            List<int> numbers = new List<int> { 5, 7, 99, -1, -7, 0, 34, 22, 6 };

            ChangeArray(numbers, Negative);
            ChangeArray(numbers, delegate (int value) { return value + 1; }); // annonymous delegates
            ChangeArray(numbers, (x) => x * 2); // lambda expression

            ShowArray(numbers, (i) => Console.Write($"{i}, ")); 
            Console.WriteLine();
            
            ShowArray(numbers, (i) =>
            {
                if (i < 0) 
                    Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"{i}, ");
                Console.ResetColor();
            });
            Console.WriteLine();

            // Action<in T> delegate - can take parameters bu without return value
            // Func<out T, in T>     - can take and return parameters
        }
    }
}