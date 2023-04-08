
using System.Diagnostics.Metrics;
using System.Drawing;

namespace ExamProg
{
    public class PlayerField
    {
        public enum ColumnNumber { а = 1, б = 2, в = 3, г = 4, д = 5, е = 6, є = 7, ж = 8, з = 9, и = 10 }
        public enum Direction { Вверх = 0, Праворуч = 1, Вниз = 2, Ліворуч = 3}

        public string[,] field;
        public PlayerField()
        {
            //------ініціалізація поля
            field = new string[10, 10];
            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    field[i, j] = "O ";
                }
            }
        }

        public void RandomGenerateField()
        {
            //---------кораблики розміром від 4 до 1
            for (int i = 4; i >= 1; i--)
            {
                RandomField(i);
            }
        }
        public void InputGenerateFild()
        {
            for (int i = 4; i >= 1; i--)
            {
                InputField(i);
            }
            Console.Clear();
            Console.WriteLine("Вітаємо! Ваше поле для бою успішно створено!");
            Console.ReadLine();
        }
        public void InputField(int size)
        {
            for (int i = 0; i < 5 - size; i++)
            {
                Console.Clear();
                //-----вивід поля
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("    а б в г д е є ж з и\n");
                for (int a = 0;  a < 10; a++)
                {
                    if(a<9)
                        Console.Write(a + 1 + "   ");
                    else
                        Console.Write(a + 1 + "  ");
                    for (int b = 0; b < 10; b++)
                    {
                        if (field[a, b] == "X ")
                            Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(field[a,b]);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    Console.WriteLine();
                }
                Console.ForegroundColor = ConsoleColor.White;

                //-------зчитування координат
                int x = 0;
                int y = 0;
                int direction = 0;
                Console.Write($"\nВведіть координати для розташування кораблика {size}x{size} (рядок та стовпчик через пробіл): ");
                try
                {
                    string[] coordinates = Console.ReadLine().Split(" ");
                    x = int.Parse(coordinates[0]) - 1;
                    y = (int)Enum.Parse<ColumnNumber>(coordinates[1]) -1;
                    if(size > 1)
                    {
                        Console.WriteLine($"Оберіть напрямок для розташування корабля\n" +
                            $"{(int)Direction.Вверх + 1} - {Direction.Вверх}\n" +
                            $"{(int)Direction.Праворуч + 1} - {Direction.Праворуч}\n" +
                            $"{(int)Direction.Вниз + 1} - {Direction.Вниз}\n" +
                            $"{(int)Direction.Ліворуч + 1} - {Direction.Ліворуч}\n");
                        direction = (int)Enum.Parse<Direction>(Console.ReadLine()) - 1;
                    }
                    else
                    {
                        direction = 1;
                    }
                }
                catch
                {
                    Console.WriteLine("Ви ввели не вірні дані!\nСпробуйте ще раз...\n");
                    i--;
                    Console.ReadLine();
                    continue;
                }

                //----------перевірка клітинок
                bool check = true;
                switch (direction)
                {
                    case 0:
                    case 2:
                        for (int j = (direction == 0 ? x - size : x - 1); j <= (direction == 0 ? x + 1 : x + size); j++)
                        {
                            if (!check)
                                break;
                            for (int h = y - 1; h <= y + 1; h++)
                            {
                                if (h < 0 || h > 9)
                                {
                                    continue;
                                }
                                else if(j < 0 || j > 9)
                                {
                                    if ((direction == 0 && j == x - size + 1) || (direction == 2 && j == x + size - 1))
                                    {
                                        check = false;
                                        break;
                                    }
                                    else
                                        continue;
                                }
                                else if (field[j, h] != "O ")
                                {
                                    check = false;
                                    break;
                                }

                            }
                        }
                        break;
                    case 1:
                    case 3:
                        for (int j = x - 1; j <= x + 1; j++)
                        {
                            if (!check) break;

                            for (int h = (direction == 1 ? y - 1 : y - size); h <= (direction == 1 ? y + size : y + 1); h++)
                            {
                                if (j < 0 || j > 9)
                                {
                                    continue;
                                }
                                else if(h < 0 || h > 9)
                                {
                                    if ((direction == 1 && h == y + size - 1) || (direction == 3 && h == y - size + 1))
                                    {
                                        check = false;
                                        break;
                                    }
                                    else
                                        continue;
                                }
                                else if (field[j, h] != "O ")
                                {
                                    check = false;
                                    break;
                                }
                            }
                        }
                        break;
                }

                //----присвоєння значення, якщо перевірка успішна
                if (check)
                {
                    switch (direction)
                    {
                        case 0:
                        case 2:
                            for (int j = (direction == 0 ? x - size + 1 : x); j <= (direction == 0 ? x : x + size - 1); j++)
                            {
                                field[j, y] = "X ";
                            }
                            break;
                        case 1:
                        case 3:
                            for (int j = (direction == 1 ? y : y - size + 1); j <= (direction == 1 ? y + size - 1 : y); j++)
                            {
                                field[x, j] = "X ";
                            }
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Нажаль в таких клітинках не можливо розташувати кораблик\n" +
                        "Спробуйте ще раз...");
                    i--;
                }

                Console.ReadLine();   
            }
        }
        public void RandomField(int size)
        {
            Random rnd = new Random();
            for (int i = 0; i < 5 - size; i++)
            {
                int x = rnd.Next(10);
                int y = rnd.Next(10);
                int direction = rnd.Next(4);

                //----------перевірка клітинок
                bool check = true;
                switch (direction)
                {
                    case 0:
                    case 2:
                        for (int j = (direction == 0 ? x - size : x - 1); j <= (direction == 0 ? x + 1 : x + size); j++)
                        {
                            if (!check)
                                break;
                            for (int h = y - 1; h <= y + 1; h++)
                            {
                                if (j < 0 || j > 9 || h < 0 || h > 9)
                                {
                                    if ((direction == 0 && j == x - size + 1) || (direction == 2 && j == x + size - 1))
                                    {
                                        check = false;
                                        break;
                                    }
                                    else
                                        continue;
                                }
                                else if (field[j, h] != "O ")
                                {
                                    check = false;
                                    break;
                                }

                            }
                        }
                        break;
                    case 1:
                    case 3:
                        for (int j = x - 1; j <= x + 1; j++)
                        {
                            if (!check) break;

                            for (int h = (direction == 1 ? y - 1 : y - size); h <= (direction == 1 ? y + size : y + 1); h++)
                            {
                                if (j < 0 || j > 9 || h < 0 || h > 9)
                                {
                                    if ((direction == 1 && h == y + size - 1) || (direction == 3 && h == y - size + 1))
                                    {
                                        check = false;
                                        break;
                                    }
                                    else
                                        continue;
                                }
                                else if (field[j, h] != "O ")
                                {
                                    check = false;
                                    break;
                                }
                            }
                        }
                        break;
                }

                //----присвоєння значення, якщо перевірка успішна
                if (check)
                {
                    switch (direction)
                    {
                        case 0:
                        case 2:
                            for (int j = (direction == 0 ? x - size + 1 : x); j <= (direction == 0 ? x : x + size - 1); j++)
                            {
                                field[j, y] = "X ";
                            }
                            break;
                        case 1:
                        case 3:
                            for (int j = (direction == 1 ? y : y - size + 1); j <= (direction == 1 ? y + size - 1 : y); j++)
                            {
                                field[x, j] = "X ";
                            }
                            break;
                    }
                }
                else
                    i--;
            }
        }
    
        public bool isLive()
        {
            int count = 0;
            for (int a = 0; a < 10; a++)
            {
                for (int b = 0; b < 10; b++)
                {
                    if (field[a, b] == "D ")
                        count++;
                }
            }
            if (count == 20)
                return false;
            else
                return true;
        }
        
        public bool checkDamage(int[] X_Y)
        {
            if (field[X_Y[0],X_Y[1]]=="X " || field[X_Y[0], X_Y[1]] == "D ")
            {
                field[X_Y[0], X_Y[1]] = "D ";
                return true;
            }
            else
            {
                field[X_Y[0], X_Y[1]] = "0 ";
                return false;
            }
        }

        public void PrintField()
        {
            //-----вивід поля
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("    а б в г д е є ж з и\n");
            for (int a = 0; a < 10; a++)
            {
                if (a < 9)
                    Console.Write(a + 1 + "   ");
                else
                    Console.Write(a + 1 + "  ");
                for (int b = 0; b < 10; b++)
                {
                    if (field[a, b] == "X ")
                        Console.ForegroundColor = ConsoleColor.Green;
                    else if (field[a, b] == "D ")
                        Console.ForegroundColor = ConsoleColor.Red;
                    else if (field[a, b] == "0 ")
                        Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(field[a, b]);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}
