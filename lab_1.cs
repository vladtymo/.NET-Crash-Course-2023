namespace lab_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1:DATE");
            int year, month, day;
            Console.Write("Enter current year: ");
            year = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter current month: ");
            month = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter cirrent day: ");
            day = Convert.ToInt32(Console.ReadLine());
            DateTime date1 = new DateTime(year, month, day);
            Console.WriteLine($"\nCurrent date:{date1.ToString("dd/MM/yyyy")}");

            Console.WriteLine("Task 2:Rectangle");
            float a, b;
            Console.Write("Enter width: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter length: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\nArea = {a * b}");
            Console.WriteLine($"Perimeter = {(a + b) * 2}");

            Console.WriteLine("Task 3: Circle ");
            float r;
            Console.Write("Enter radius: ");
            r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\nArea of a circle= {3.14 * r * r}");

            Console.WriteLine("Task 4: Time ");
            int s1, h, m, s;
            Console.Write("Enter time in seconds:");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{s1}");
            h = s1 / 3600;
            m = (s1 - 3600 * h) / 60;
            s = s1 - m * 60 - h * 3600;
            DateTime time1 = new DateTime(1, 1, 1, h, m, s);
            Console.WriteLine($"\n Time = {time1.ToString("HH:mm:ss")}");

            Console.WriteLine("Task 5: Time ");
            int y;
            Console.Write("Enter year: ");
            y = Convert.ToInt32(Console.ReadLine());
            if(y%4==0 && y%100!=0 || y%4==0 && y%100==0 && y%400==0 ) Console.WriteLine($"This year({y}) has 366 days");
            else Console.WriteLine($"This year({y}) has 365 days");
        }
    }
}