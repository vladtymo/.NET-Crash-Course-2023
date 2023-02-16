using System;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int randomNumber = rand.Next(1, 101);
            int attempts = 0;
            
            while (true)
            {
                Console.Write("Guess the number: ");
                int guess = int.Parse(Console.ReadLine());
                attempts++;
                
                if (guess == randomNumber)
                {
                    Console.WriteLine("You got it! The number was {0}.", randomNumber);
                    Console.WriteLine("It took you {0} attempts to guess the number.", attempts);
                    break;
                }
                else if (guess < randomNumber)
                {
                    Console.WriteLine("The number is higher.");
                }
                else
                {
                    Console.WriteLine("The number is lower.");
                }
            }
        }
    }
}

