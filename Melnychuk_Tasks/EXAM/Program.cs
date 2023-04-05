using EXAM;
using System;
using System.Diagnostics;
using System.Globalization;
using System.Threading;


namespace Exam
{
    public class Program
    {
        static void Main(string[] args)
        {
            BeautySalon beautySalon = new BeautySalon();
            Greeting(ref beautySalon);
        }

        #region methods
        public static void Greeting(ref BeautySalon beauty)
        {
            Console.WriteLine("Привіт ти попав у перукарню");
            Console.WriteLine("\n\nдля початку тобі потрібно заповнити перукарню.\nтому давай почнемо");
            Wait();
            Console.Clear();
            beauty.AddPerson();
            Wait();
            Console.Clear();
            beauty.AddService();
            Wait();
            Console.Clear();
            beauty.AddProduct();
            Wait();
            Console.Clear();
            int process = 1;
            while (process != 0) 
            {
               process = BarberShopInterface(ref beauty);
            }

        }
        public static int Show(ref BeautySalon beauty)
        {
            Console.Clear();
            Console.WriteLine("\t\tМеню");
            Console.WriteLine("Показати список Persons \t-1");
            Console.WriteLine("Показати список Services \t-2");
            Console.WriteLine("Показати список Products \t-3");
            Console.WriteLine("Показати список Orders \t-4");
            Console.WriteLine("Повернутись назад \t- 0");

            Console.Write("\n\n\n\tВаш вибір:");
            int variant = int.Parse(Console.ReadLine());
            switch (variant)
            {
                case 0: return 0;
                case 1:
                    Console.Clear();
                    beauty.ShowPerson();
                    Wait();
                    break;
                case 2:
                    Console.Clear();
                    beauty.ShowService();
                    Wait();
                    break;
                    case 3:
                    Console.Clear();
                    beauty.ShowProduct();
                    Wait(); 
                    break;
                    case 4:
                    Console.Clear();
                    beauty.ShowOrder(); Wait(); break;
                default:
                    break;
            }
            return 1;
        }
        public static int BarberShopInterface(ref BeautySalon beauty)
        {
            Console.Clear();
            Console.WriteLine("\t\tМеню");
            Console.WriteLine("Відкрити перелік списків об'єктів \t- 1");
            Console.WriteLine("Додати \t- 2");
            Console.WriteLine("Редагувати \t - 3");
            Console.WriteLine("Видалити \t - 4");
            Console.WriteLine("Виконати замовлення \t - 5");
            Console.WriteLine("Завершити роботу \t- 0");

            Console.Write("\n\n\n\tВаш вибір:");
            int variant = int.Parse(Console.ReadLine());
            int process2 = 1;
            switch (variant)
            {
                case 0: return 0;
                case 1:                   
                    while (process2 != 0)
                    {
                        process2 = Show(ref beauty);
                    }                   
                    break;
                case 2:                   
                    while (process2 != 0)
                    {
                        process2 = Adder(ref beauty);
                    }
                    break;
                case 3:
                    while (process2 != 0)
                    {
                        process2 = Editor(ref beauty);
                    }                   
                    break;
                case 4:                   
                    while (process2 != 0)
                    {
                        process2 = Remover(ref beauty);
                    }
                    break;
                case 5:
                    while (process2 != 0)
                    {
                        beauty.ShowOrder();
                        Console.Write("\n\n\n\tВаш вибір(номер ордеру):");
                        int number = int.Parse(Console.ReadLine()) - 1;
                        beauty.Orders[number].Work();
                        beauty.Orders.RemoveAt(number);
                        Console.Clear();
                    }
                    break;
                        default:
                    break;
            }

            return 1;
        }
        public static int Index()
        {
            Console.Write("Введіть номер об'єкта якого хочете змінити:");
            
            return int.Parse(Console.ReadLine()) - 1;
        }
        public static int Adder(ref BeautySalon beauty)
        {
            Console.Clear();

            Console.WriteLine("\t\tМеню");
            Console.WriteLine("Додати - Person  - 1");
            Console.WriteLine("Додати - Service - 2");
            Console.WriteLine("Додати - Product - 3");
            Console.WriteLine("Додати - Order   - 4");
            Console.Write("\n\n\n\tВаш вибір:");
            int variant = int.Parse(Console.ReadLine());
            switch (variant)
            {
                case 0: return 0;
                case 1:
                    beauty.ShowPerson();
                    beauty.AddPerson();
                    break;
                case 2:
                    beauty.ShowService();
                    beauty.AddService();
                    break;
                case 3:
                    beauty.ShowProduct();
                    beauty.AddProduct();
                    break;
                case 4:
                    beauty.ShowOrder();
                    beauty.AddOrder();
                    break;

                default:
                    break;
            }

            return 1;

        }
        public static int Remover(ref BeautySalon beauty)
        {
            Console.Clear();

            Console.WriteLine("\t\tМеню");
            Console.WriteLine("Видали - Person  - 1");
            Console.WriteLine("Видали - Service - 2");
            Console.WriteLine("Видали - Product - 3");
            Console.WriteLine("Видали - Order   - 4");
            Console.Write("\n\n\n\tВаш вибір:");
            int variant = int.Parse(Console.ReadLine());
            switch (variant)
            {
                case 0: return 0;
                case 1:
                    beauty.ShowPerson();
                    beauty.RemovePerson();
                    break;
                case 2:
                    beauty.ShowService();
                    beauty.RemoveService();
                    break;
                case 3:
                    beauty.ShowProduct();
                    beauty.RemoveProduct();
                    break;
                case 4:
                    beauty.ShowOrder();
                    beauty.RemoveOrder();
                    break;

                default:
                    break;
            }

            return 1;

        }
        public static int Editor(ref BeautySalon beauty)
        {
            Console.Clear();

            Console.WriteLine("\t\tМеню");
            Console.WriteLine("Редагувати - Person - 1");
            Console.WriteLine("Редагувати - Service - 2");
            Console.WriteLine("Редагувати - Product - 3");            
            Console.Write("\n\n\n\tВаш вибір:");
            int variant = int.Parse(Console.ReadLine());
            switch (variant)
            {
                case 0: return 0;
                case 1:
                    beauty.ShowPerson();
                    beauty.Persons[Index()].Edit();
                    break;
                case 2:
                    beauty.ShowService();                   
                    beauty.Services[Index()].Edit();
                    break;
                case 3:
                    beauty.ShowProduct();                    
                    beauty.Products[Index()].Edit();
                    break;
                
                default:
                    break;
            }

            return 1;
            
        }
        public static void Wait()
        {
            Console.WriteLine("\n\n\n\n\n\n\t\t\tНатисність будь що для продовження..");
            Console.ReadKey();
        }
        #endregion

        #region Enums
        public enum Names 
        {
            Alexander = 1,
            Dale = 2,
            Clyde = 3,
            Ian = 4,
            Max = 5,
            Justine = 6,
            Merry = 7,
            Nellie = 8,
            Natalia = 9,
            Louisa = 10,
            Mabel = 11,
            Margaret = 12

        }
        public enum Surnames
        {
            Adamson = 1,
            Bush = 2,
            Cooper = 3,
            Ford = 4,
            King = 5,
            Wesley = 6,
            Wood = 7,
            Smith = 8
   
        }
        #endregion

    }
}