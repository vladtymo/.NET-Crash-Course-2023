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
            Console.WriteLine("\n\n\t\t\tПривіт ти попав у перукарню");
            Console.WriteLine("\n\n\t\tдля початку тобі потрібно заповнити перукарню.\n\t\t\tтому давай почнемо");
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
            Console.WriteLine("\t\t\t\tМеню");
            Console.WriteLine("Показати список Persons \t\t- 1");
            Console.WriteLine("Показати список Services \t\t- 2");
            Console.WriteLine("Показати список Products \t\t- 3");
            Console.WriteLine("Показати список Orders \t\t\t- 4");
            Console.WriteLine("Повернутись назад \t\t\t- 0");

            Console.Write("\n\n\n\t\t\tВаш вибір:");
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
            Console.WriteLine("\n\t\t\t\tМеню");
            Console.WriteLine("\t\tВідкрити перелік списків об'єктів - 1");
            Console.WriteLine("\t\tДодати \t\t\t\t  - 2");
            Console.WriteLine("\t\tРедагувати \t\t\t  - 3");
            Console.WriteLine("\t\tВидалити \t\t\t  - 4");
            Console.WriteLine("\t\tВиконати замовлення \t\t  - 5");
            Console.WriteLine("\t\tЗавершити роботу \t\t  - 0");

            Console.Write("\n\n\n\t\t\tВаш вибір:");
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
                        Console.Write("\n\n\n\t\t\tВаш вибір(номер ордеру):");
                        int number = int.Parse(Console.ReadLine()) - 1;
                        beauty.Orders[number].Work();
                        beauty.Orders.RemoveAt(number);
                        Console.Clear();
                        process2 = 0;
                    }
                    break;
                        default:
                    break;
            }

            return 1;
        }
        public static int Index()
        {
            Console.Write("\t\tВведіть номер об'єкта якого хочете змінити:");
            
            return int.Parse(Console.ReadLine()) - 1;
        }
        public static int Adder(ref BeautySalon beauty)
        {
            Console.Clear();

            Console.WriteLine("\n\t\t\t\tМеню");
            Console.WriteLine("\t\t Додати - Person   - 1");
            Console.WriteLine("\t\t Додати - Service  - 2");
            Console.WriteLine("\t\t Додати - Product  - 3");
            Console.WriteLine("\t\t Додати - Order    - 4");
            Console.WriteLine("\t\t Повернутись назад - 0");
            Console.Write("\n\n\n\t\t\tВаш вибір:");
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

            Console.WriteLine("\n\t\t\t\tМеню");
            Console.WriteLine("\t\tВидали - Person  - 1");
            Console.WriteLine("\t\tВидали - Service - 2");
            Console.WriteLine("\t\tВидали - Product - 3");
            Console.WriteLine("\t\tВидали - Order   - 4");
            Console.Write("\n\n\n\tВаш вибір:");
            int variant = int.Parse(Console.ReadLine());
            switch (variant)
            {
                case 0: return 0;
                case 1:                 
                    beauty.RemovePerson();
                    break;
                case 2:                  
                    beauty.RemoveService();
                    break;
                case 3:                    
                    beauty.RemoveProduct();
                    break;
                case 4:                   
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

            Console.WriteLine("\n\t\t\t\tМеню");
            Console.WriteLine("\t\tРедагувати - Person  - 1");
            Console.WriteLine("\t\tРедагувати - Service - 2");
            Console.WriteLine("\t\tРедагувати - Product - 3");            
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