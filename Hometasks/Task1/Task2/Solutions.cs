using System.ComponentModel.DataAnnotations;

namespace Task2
{
    public class Solutions
    {
        // Ex1
        private enum DayOfWeek : byte
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6,
            Sunday = 7,
        }

        // Ex2
        private enum CurrencyType : byte // Ex2
        {
            UAH = 1,
            USD = 2,
            EUR = 3,
            PLN = 4,
        }
        private float[,] _currencyTransfer = new float[,] // Ex3
        {
                      /*UAH*/   /*USD*/    /*EUR*/   /*PLN*/
            /*UAH*/ { 1,        37.28f,    40.35f,   8.53f, },
            /*USD*/ { 0.027f,   1,         1.08f,    0.23f, },
            /*EUR*/ { 0.025f,   0.92f,     1,        0.21f, },
            /*PLN*/ { 0.12f,    4.37f,     4.72f,    1, },
        };

        // Ex3
        private enum Actions
        {
            [Display(Name = "Get Radius")]
            GetRadius = 1,

            [Display(Name = "Get Area")]
            GetArea = 2,

            [Display(Name = "Get Perimetr")]
            GetPerimetr = 3,
        }

        public void Exercise1()
        {
            Console.Write("Number of the day: ");
            if(!byte.TryParse(Console.ReadLine(), out byte dayNumber))
            {
                Console.Write("Invalida value. Try again: ");
                while(!byte.TryParse(Console.ReadLine(), out dayNumber))
                {
                    Console.Write("Invalida value. Try again: ");
                }
            }

            if(!Enum.IsDefined(typeof(DayOfWeek), dayNumber))
            {
                Console.WriteLine("Invalid value of day.");
            }
            else
            {
                Console.WriteLine((DayOfWeek)dayNumber);
            }
        }

        public void Exercise2()
        {
            foreach(byte i in Enum.GetValues(typeof(CurrencyType))) 
                Console.WriteLine($"{(CurrencyType)i} - {i}");

            Console.Write("Convert from: ");
            if(!byte.TryParse(Console.ReadLine(), out byte currency) || 
                !Enum.IsDefined(typeof(CurrencyType), currency))
            {
                Console.Write("Invalid value. Try again: ");
                while(!byte.TryParse(Console.ReadLine(), out currency) ||
                    !Enum.IsDefined(typeof(CurrencyType), currency))
                {
                    Console.Write("Invalid value. Try again: ");
                }
            }

            Console.WriteLine("\nConvert to:");
            foreach(byte i in Enum.GetValues(typeof(CurrencyType)))
            {
                Console.WriteLine($"{(CurrencyType)i}: {_currencyTransfer[i - 1, currency - 1]}");
            }

            if(!byte.TryParse(Console.ReadLine(), out byte convert) ||
                !Enum.IsDefined(typeof(CurrencyType), convert))
            {
                Console.Write("Invalid value. Try again: ");
                while (!byte.TryParse(Console.ReadLine(), out convert) ||
                    !Enum.IsDefined(typeof(CurrencyType), convert))
                {
                    Console.Write("Invalid value. Try again: ");
                }
            }

            Console.Write("\nAmount: ");
            if(!float.TryParse(Console.ReadLine(), out float amount))
            {
                Console.Write("Invalid value. Try again: ");
                while(!float.TryParse(Console.ReadLine(), out amount))
                {
                    Console.Write("Invalid value. Try again: ");
                }
            }

            Console.WriteLine($"\nYou paid: {amount}\nYou got: {_currencyTransfer[convert - 1, currency - 1] * amount}");
        }

        public void Exercise3()
        {
            Console.Write("Diametr: ");
            if(!double.TryParse(Console.ReadLine(), out double diametr))
            {
                Console.Write("Invalid value. Try again: ");
                while(!double.TryParse(Console.ReadLine(), out diametr))
                {
                    Console.Write("Invalid value. Try again: ");
                }
            }

            foreach(int i in Enum.GetValues(typeof(Actions)))
            {
                Console.WriteLine((Actions)i);
            }

            Console.Write("Choose the action: ");

            if(!byte.TryParse(Console.ReadLine(), out byte action) ||
                !Enum.IsDefined(typeof(Actions), (int)action))
            {
                Console.Write("Invalid value. Try again: ");
                while(!byte.TryParse(Console.ReadLine(), out action) ||
                    !Enum.IsDefined(typeof(Actions), action))
                {
                    Console.Write("Invalid value. Try again: ");
                }
            }

            double radius = diametr / 2;
            switch((Actions)action)
            {
                case Actions.GetPerimetr:
                    {
                        double perimetr = 2 * Math.PI * radius;
                        Console.WriteLine($"Perimetr: {perimetr}");
                        break;
                    }
                case Actions.GetArea:
                    {
                        double area = Math.PI * Math.Pow(radius, 2);
                        Console.WriteLine($"Area: {area}");
                        break;
                    }
                case Actions.GetRadius:
                    {
                        Console.WriteLine($"Radius: {radius}");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Something went wrong");
                        break;
                    }
            }
        }

        public void Exercise4()
        {
            Console.Write("String: ");
            string str = Console.ReadLine();

            bool isPalindrome = true;
            for(int i = 0; i < str.Length / 2; i++)
            {
                if(str[i] != str[str.Length - 1 - i])
                {
                    isPalindrome = false;
                    break;
                }
            }

            if(isPalindrome)
            {
                Console.WriteLine("Is");
            }
            else
            {
                Console.WriteLine("Not");
            }
        }
    }
}