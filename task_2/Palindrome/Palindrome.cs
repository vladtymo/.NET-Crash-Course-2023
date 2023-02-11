internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter number or word: ");
        string palindrome = Console.ReadLine();
        int size = palindrome.Length;
        int check=1;
        for (int i = 0; i < size; i++)
        {
            if (palindrome[i] != palindrome[size-1-i]) { check = 0; break; }
        }
            switch (check)
            {
                case 1:
                    Console.WriteLine($"Number: {palindrome} is palindrome");
                    break;
                default:
                    Console.WriteLine($"Number: {palindrome} is not palindrome");
                    break;
            }
     
    }
}