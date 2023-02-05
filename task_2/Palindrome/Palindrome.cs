internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter number: ");
        string palindrome = Console.ReadLine();
        int size = palindrome.Length / 2;
        int k = size+1;
        if (palindrome.Length % 2 == 0)
        {
            for (int i = 0; i <= size; i++)
            {
                if (palindrome[i] == palindrome[size + (size - i - 1)]) k--;
            }
            switch (k)
            {
                case 0:
                    Console.WriteLine($"Number: {palindrome} is palindrome");
                    break;
                default:
                    Console.WriteLine($"Number: {palindrome} is not palindrome");
                    break;
            }
        }
        else
        {
            for (int i = 0; i <= size; i++)
            {
                if (palindrome[i] == palindrome[size + (size - i)]) k--;
            }
            switch (k)
            {
                case 0:
                    Console.WriteLine($"Number: {palindrome} is palindrome");
                    break;
                default:
                    Console.WriteLine($"Number: {palindrome} is not palindrome");
                    break;
            }
        }
    }
}