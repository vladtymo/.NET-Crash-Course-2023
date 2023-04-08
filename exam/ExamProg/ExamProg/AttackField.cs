

using System.Drawing;
using static ExamProg.PlayerField;

namespace ExamProg
{
    public class AttackField
    {
        public enum ColumnNumber { а = 1, б = 2, в = 3, г = 4, д = 5, е = 6, є = 7, ж = 8, з = 9, и = 10 }

        public string[,] field;
        private int x = 0;
        private int y = 0;

        public AttackField()
        {
            //------ініціалізація поля
            field = new string[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    field[i, j] = "O ";
                }
            }
        }

        public int[] pcMakeAttack(PlayerField playerField)
        {
            Console.Clear();
            PrintOneField();

            Random rnd = new Random();
            while (true)
            {
                x = rnd.Next(10);
                y = rnd.Next(10);

                if (field[x, y] == "O ")
                {
                    return new int[] { x, y };
                }
            }
        }

        public int[] makeAttack(PlayerField playerField)
        {
            PrintField(playerField);

            try
            {
                Console.Write($"\nВведіть координати для удару (рядок та стовпчик через пробіл): ");
                string[] coordinates = Console.ReadLine().Split(" ");
                x = int.Parse(coordinates[0]) - 1;
                y = (int)Enum.Parse<ColumnNumber>(coordinates[1]) - 1;
            }
            catch
            {
                Console.WriteLine("Ви ввели не вірні дані!\nНажаль ви втрачаєте свій хід...\n");
                Console.ReadLine();
                return null;
            }

            PrintField(playerField);

            return new int[] {x, y };
        }
        public void checkKillShip(PlayerField damagedField)
        {
            string[,] field = damagedField.field;

            //----------шукаємо крайні точки де є клітинки з літерою D
            int leftY = y;
            int rightY = y;
            
            int leftX = x;
            int rightX = x;

            if (leftY != 0)
            {
                while (field[x, leftY - 1] == "D ")
                {
                    leftY--;
                    if (leftY == 0)
                        break;
                }
            }

            if (rightY != 9)
            {
                while (field[x, rightY + 1] == "D ")
                {
                    rightY++;
                    if (rightY == 9)
                        break;
                }
            }
               
            if(leftX != 0)
            {
                while (field[leftX - 1, y] == "D ")
                {
                    leftX--;
                    if (leftX == 0)
                        break;
                }
            }
            
            if(rightX != 9)
            {
                while (field[rightX + 1, y] == "D ")
                {
                    rightX++;
                    if (rightX == 9)
                        break;
                }
            }

            if(leftY > 0 && field[x, leftY - 1] == "X ")
                return;
            else if (leftX > 0 && field[leftX - 1, y] == "X ")
                return;
            else if (rightX < 9 && field[rightX + 1, y] == "X ")
                return;
            else if (rightY < 9 && field[x, rightY + 1] == "X ")
                return;
            else
            {
                for (int j = leftY - 1; j <= rightY + 1; j++)
                {
                    if (j < 0 || j > 9)
                        continue;
                    else
                    {
                        if(leftX > 0)
                        {
                            this.field[leftX - 1, j] = "0 ";
                            damagedField.field[leftX - 1, j] = "0 ";
                        }
                        if (rightX < 9)
                        {
                            this.field[rightX + 1, j] = "0 ";
                            damagedField.field[rightX + 1, j] = "0 ";
                        }
                    }
                }

                for (int j = leftX; j <= rightX; j++)
                {
                    if (j < 0 || j > 9)
                        continue;
                    else
                    {
                        if (leftY > 0)
                        {
                            this.field[j, leftY - 1] = "0 ";
                            damagedField.field[j, leftY - 1] = "0 ";
                        }
                        if(rightY < 9)
                        {
                            this.field[j, rightY + 1] = "0 ";
                            damagedField.field[j, rightY + 1] = "0 ";
                        }
                    }
                }
            }
        }
        public void confirmPCDamage(bool isDamage, PlayerField damagedField)
        {
            if (isDamage)
            {
                field[x, y] ="X ";
                checkKillShip(damagedField);
            }
            else
            {
                field[x, y] = "0 ";
            }
           
            Console.Clear();
            PrintOneField();

        }
        public void confirmDamage(bool isDamage, PlayerField playerField, PlayerField damagedField)
        {
            if (isDamage)
            {
                field[x, y] = "X ";
                checkKillShip(damagedField);
            }
            else
            {
                field[x, y] = "0 ";
            }
            PrintField(playerField);
        }
        public void PrintOneField()
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
                    else if (field[a, b] == "0 ")
                        Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(field[a, b]);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;

        }
        public void PrintField(PlayerField playerField)
        {

            Console.Clear();
            playerField.PrintField();
            Console.WriteLine("\n\n");

            PrintOneField();
        }
    }
}
