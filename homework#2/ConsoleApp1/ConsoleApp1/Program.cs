
enum days {Monday = 1, Tuesday = 2, Wendsday = 3, Thursday = 4, Friday = 5, Saturday = 6, Sunday = 7};
enum cash { USD = 40, EUR = 41, PLN =8};
enum circle { radius =1, area = 2, circuit = 3};
internal class Program
{
    private static void Main(string[] args)
//////////////// task 1///////////////////
    {
        Console.WriteLine("Введіть номер дня тижня: \n"  +
            $"{(int)days.Monday} - {days.Monday}\n" +
            $"{(int)days.Tuesday} - {days.Tuesday}\n" +
            $"{(int)days.Wendsday} - {days.Wendsday}\n" +
            $"{(int)days.Thursday} - {days.Thursday}\n" +
            $"{(int)days.Friday} - {days.Friday}\n" +
            $"{(int)days.Saturday} - {days.Saturday}\n" +
            $"{(int)days.Sunday} - {days.Sunday}\n");

        days direction = Enum.Parse<days>(Console.ReadLine());

        switch (direction)
        {
            case days.Monday:
                Console.WriteLine("ponedilok");
                break;
            case days.Tuesday: Console.WriteLine("vivtorok"); break;
            case days.Wendsday: Console.WriteLine("sereda"); break;
            case days.Thursday: Console.WriteLine("chetver"); break;
            case days.Friday: Console.WriteLine("pyatnica"); break;
            case days.Saturday: Console.WriteLine("subota"); break;
            case days.Sunday: Console.WriteLine("nedilya"); break;
            default: Console.WriteLine("takogo dnya nemae"); break;
        }
        ////////////////// task2////////////////
        Console.WriteLine("Kurs valyut syogodi takiy:\n" +
               $"{(int)cash.USD} - {cash.USD}\n" +
               $"{(int)cash.EUR} - {cash.EUR}\n" +
               $"{(int)cash.PLN} - {cash.PLN} \n");
        Console.WriteLine("Vvedit sumu v UAH");
        int grn = int.Parse(Console.ReadLine());
        Console.WriteLine("Oberit valyutu dlya konvertacii: USD, EUR, PLN");
        cash money = Enum.Parse<cash>(Console.ReadLine());
        switch (money)
        {
            case cash.USD: Console.WriteLine($" Suma v PLN = {grn / 40}"); break;
            case cash.EUR: Console.WriteLine($" Suma v EURO = {grn / 41}"); break;
            case cash.PLN: Console.WriteLine($" Suma v PLN = {grn/8}"); break;
                default : Console.WriteLine("Takoi valuti ne maye v obmini"); break;

        }
        ////////////////task 3////////////////
        Console.WriteLine("Що порахувати?:\n" +
            $"{(int)circle.radius} - {circle.radius}\n" +
               $"{(int)circle.area} - {circle.area}\n" +
               $"{(int)circle.circuit} - {circle.circuit} \n");
        Console.WriteLine("Vvedit diameter");
        int diameter = int.Parse(Console.ReadLine());
        Console.WriteLine("Рахуємо radius, area чи circuit?");
        circle pi = Enum.Parse<circle>(Console.ReadLine());
        switch (pi)
        {
            case circle.radius: Console.WriteLine($" Radius = {diameter / 2}"); break;
            case circle.area: Console.WriteLine($" Area of circle = {(diameter / 2)^2*3,14}"); break;
            case circle.circuit: Console.WriteLine($" Circuit = {(diameter / 2)*6,28}"); break;
            default: Console.WriteLine("Erorr"); break;

        }
    }

}