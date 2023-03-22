namespace c2
{
    public class Program2
    {

        enum Week { Monday = 1, Tuesday = 2, Wednesday = 3, Thursday = 4, Friday = 5, Saturday = 6, Sunday = 7 }

        enum Converter_v { USD = 40, EUR = 44, PLN = 9 }

        public static void Main2(string[] args)
        {

            
            Console.Write("\n\tEnter count :  ");

            float money = float.Parse(Console.ReadLine());




            Console.WriteLine("Choose currency :\n" +
                              $"{(int)Converter_v.USD} - {Converter_v.USD}\n" +
                            $"{(int)Converter_v.EUR} - {Converter_v.EUR}\n" +
                            $"{(int)Converter_v.PLN} - {Converter_v.PLN}\n");

            Console.Write("\n\t Enter:");
            Converter_v currency = Converter_v.Parse<Converter_v>(Console.ReadLine());


            switch (currency)
            {
                case Converter_v.USD: Console.WriteLine($"You will get - {money / (float)Converter_v.USD} USD"); break;
                case Converter_v.EUR: Console.WriteLine($"You will get - {money / (float)Converter_v.EUR} EUR"); break;
                case Converter_v.PLN: Console.WriteLine($"You will get - {money / (float)Converter_v.PLN} PLN"); break;
                default: Console.WriteLine("Sorry,  we don't have the currency  you enter"); break;
            }

        }
    }
}