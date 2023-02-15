//task 1
// enum Days { Monday=1,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday };

//task 2
//enum Currency {USD=1,EUR,PLN,GBR };

//task 3
enum Operation { getR = 1, getS, getP };
internal class Program
{
    private static void Main(string[] args){
        //Task 1
        //Console.WriteLine("Input num of day: ");
        //Days num = Enum.Parse<Days>(Console.ReadLine());
        //switch (num){
        //    case Days.Monday:
        //        Console.WriteLine("Day is monday");
        //        break;
        //    case Days.Tuesday:
        //        Console.WriteLine("Day is tuesday");
        //        break;
        //    case Days.Wednesday: Console.WriteLine("Day is wednesday");
        //        break;
        //    case Days.Thursday: Console.WriteLine("Day is thursday");
        //        break;
        //    case Days.Friday:Console.WriteLine("Day is friday");
        //        break;
        //    case Days.Saturday:Console.WriteLine("Day is saturday");
        //        break;
        //    case Days.Sunday:Console.WriteLine("Day is sunday");
        //        break;
        //    default: Console.WriteLine("Invalid number");
        //        break;
        //}

        //Task 2
        //const float valueUSD = 40.0F;
        //const float valueEUR = 43.40F;
        //const float valuePLN = 9.20F;
        //const float valueGBR = 48.50F;

        //Console.WriteLine("Input value of UAH: ");
        //float value=float.Parse(Console.ReadLine()); 
        //Console.WriteLine("Input num of currency:\n" +
        //    "1 - USD \n" +
        //    "2 - EUR \n" +
        //    "3 - PLN \n" +
        //    "4 - HBR");
        //Currency num = Enum.Parse<Currency>(Console.ReadLine());
        //switch (num){
        //    case Currency.USD:Console.WriteLine($"UAH to USD:\n{value} - {value/valueUSD} ");
        //        break;
        //    case Currency.EUR:
        //        Console.WriteLine($"UAH to EUR:\n{value} - {value / valueEUR} ");
        //        break;
        //    case Currency.PLN:
        //        Console.WriteLine($"UAH to PLN:\n{value} - {value / valuePLN} ");
        //        break;
        //    case Currency.GBR:
        //        Console.WriteLine($"UAH to GBR:\n{value} - {value / valueGBR} ");
        //        break;
        //        default: Console.WriteLine("We dont do operations with this currency");
        //        break;
        //}

        //Task 3
        Console.WriteLine("Input d: ");
        int d = int.Parse(Console.ReadLine());
        Console.WriteLine("Input num of operation:\n" +
            "1 - get radius \n" +
            "2 - get area \n" +
            "3 - get perimetr");
        Operation num = Enum.Parse<Operation>(Console.ReadLine());
        switch (num){
            case Operation.getR:
                int r = d / 2;
                Console.WriteLine($"Radius={r}");
                break;
            case Operation.getS:
                float s =(float) Math.Pow((Math.PI * (d / 2)), 2);    
                Console.WriteLine($"Area= {s}");
                break;
            case Operation.getP:
                float p =(float) (2 * Math.PI * (d / 2));
                Console.WriteLine($"Perimetr= {p}");
                break;
            default:
                Console.WriteLine("Unknown operation!");
                break;
        }
    }
}
