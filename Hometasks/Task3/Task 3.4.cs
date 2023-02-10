using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[20];
            for (int i = 0; i < arr.Length; i++)
            {
                Random random = new Random();
                arr[i] = random.Next(0, 101);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            bool cikl = true;
            while (cikl)
            {
                Console.WriteLine("Виберіть дію яку хочете виконати:\n" + "1-сума всіх елементів\n" + "2-відсортувати масив\n" + "3-знайти к-ть парних значень\n" + "4-" + " найбільший елемент\n0-завершити програму");
                int vubir = Convert.ToInt32(Console.ReadLine());
                switch (vubir)
                {
                    case 0:
                        cikl = false;
                        break;
                    case 1:
                        int sum = 0;
                        for (int i = 0; i < arr.Length; i++)
                        {
                            sum += arr[i];
                        }
                        Console.WriteLine("Сума усіх елементів: " + sum);
                        break;

                    case 2:
                        Array.Sort(arr);
                        for (int i = 0; i < arr.Length; i++)
                        {
                            Console.Write(arr[i] + " ");
                        }
                        break;

                    case 3:
                        int k = 0;
                        for (int i = 0; i < arr.Length; i++)
                        {
                            if (arr[i] % 2 == 0)
                            {
                                ++k;
                            }
                        }
                        Console.WriteLine("К-ть парних елементів: " + k);
                        break;

                    case 4:
                        int max = arr[0];

                        for (int i = 0; i < arr.Length; i++)
                        {
                            if (max < arr[i])
                            {
                                max = arr[i];
                            }
                        }
                        Console.WriteLine("Максимальний елемент: " + max);
                        break;


                    default:
                        Console.WriteLine("Неправильно вибрана дія");
                        break;
                }

            }


        }
    }
}
