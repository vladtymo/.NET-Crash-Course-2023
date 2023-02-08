
using System;

public class HelloWorld
{



    public static void Main(string[] args)
    {


        /////// TASK //////
        Console.WriteLine(" /////// TASK //////");

        Console.Write("\n\n\t\tEnter symbol: ");
        char symbol = char.Parse(Console.ReadLine());

        Console.Write("\n\n\t\tEnter count: ");
        int count = int.Parse(Console.ReadLine());


        Console.Write("\n\n\t\tRESULT: ");
        for (int i = 0; i < count; i++)
        {
            Console.Write(symbol);
        }





        /////// TASK //////
        Console.WriteLine("\n\n\n\t\t\t /////// TASK //////");


        Random rand = new Random();

        int number_f = rand.Next(1, 10);

        int number_s = -1;

        int number_of_attempts = 0;


        while(number_f != number_s)
        {
            Console.Write("\t Вгадайте число число від 1 до 10 : ");
            number_s = int.Parse(Console.ReadLine());
            number_of_attempts++;
            if (number_f == number_s)
            {
                Console.WriteLine($"\n\t\t Ви вгадали чисто {number_f}| витрачених спроб - {number_of_attempts}");
            }
            else { Console.WriteLine("\t Ви не вгадали спробуйте ще раз"); }
        }


        /////// TASK //////
        Console.WriteLine("\n\n\n\t\t\t /////// TASK //////");



        int[] array = new int[20];


        Console.WriteLine("\n\n\t\t\tARRAY");
        for (int i = 0; i < array.Length; i++)
        {

            array[i] = rand.Next(0, 100);
            Console.Write($" {array[i]} | ");


        }

        int sum = 0;

        for (int i = 0; i < array.Length; i++)
        {

            sum += array[i];
        }

        Console.WriteLine($"\n\n\t\t Сума всіх елементів масива рівна - {sum}");
        int max = array[0];
        int p_count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (max < array[i])
            {
                max = array[i];
            }

            if (array[i]%2==0)
            {
                ++p_count;
            }
        }

        Console.WriteLine($"\n\n\t\t Максимальне число рівне - {max}");
        Console.WriteLine($"\n\n\t\t Кількість парних чисел - {p_count}");

        Array.Sort(array);

        Console.WriteLine("\n\n\t\t\tARRAY .Sort");
        for (int i = 0; i < array.Length; i++)
        {

            Console.Write($" {array[i]} | ");


        }


        Array.Reverse(array);

        Console.WriteLine("\n\n\t\t\tARRAY .Reverse");
        for (int i = 0; i < array.Length; i++)
        {

            Console.Write($" {array[i]} | ");


        }


       

        Console.ReadLine();


    }
}