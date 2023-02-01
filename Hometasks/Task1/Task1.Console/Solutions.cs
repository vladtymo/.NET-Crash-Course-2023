namespace Task1.Console
{
    public class Solutions
    {
        public void Exercise1()
        {
            System.Console.Write("Year: ");
            if(!short.TryParse(System.Console.ReadLine(), out short year))
            {
                System.Console.Write("Invalid value of year, Try again: ");
            }

            System.Console.Write("Month: ");
            if(!byte.TryParse(System.Console.ReadLine(), out byte month))
            {
                System.Console.Write("Invalid value of month. Try again: ");
            }

            System.Console.Write("Day: ");
            if(!byte.TryParse(System.Console.ReadLine(), out byte day))
            {
                System.Console.Write("Invalid value of day. Try again: ");
            }

            if(!DateTime.TryParse($"{year}.{month}.{day}", out DateTime now))
            {
                System.Console.Write($"{now.ToString()} is not a correct date");
            }
            System.Console.WriteLine(now.ToString("dd.MM.yyyy"));
        }

        public void Exercise2()
        {
            System.Console.Write("First side: ");
            if(!double.TryParse(System.Console.ReadLine(), out double firstSide))
            {
                System.Console.Write("Invalid value. Try again: ");
            }

            System.Console.Write("Second side: ");
            if(!double.TryParse(System.Console.ReadLine(), out double secondSide))
            {
                System.Console.Write("Invalid value. Try again: ");
            }
            
            double perimetr = 2 * firstSide + 2 * secondSide;
            double area = firstSide * secondSide;

            System.Console.WriteLine(perimetr);
            System.Console.WriteLine(area);
        }

        public void Exercise3()
        {
            System.Console.Write("Radius: ");
            if(!double.TryParse(System.Console.ReadLine(), out double radius))
            {
                System.Console.Write("Invalid value. Try again: ");
            }

            double circleLength = 2 * Math.PI * radius;
            double circleArea = 2 * Math.PI * Math.Pow(radius, 2);

            System.Console.WriteLine(circleLength);
            System.Console.WriteLine(circleArea);
        }

        public void Exercise4()
        {
            System.Console.Write("Seconds number: ");
            if(!ulong.TryParse(System.Console.ReadLine(), out ulong seconds))
            {
                System.Console.Write("Invalid value. Try again: ");
            }

            ushort hours = (ushort)(seconds / 3600 % 24);
            ushort minutes = (ushort)(seconds / 60 % 60);
            seconds = seconds % 60;
            
            System.Console.WriteLine($"{(hours <= 10 ? "0" + hours : hours)}:{(minutes <= 10 ? "0" + minutes : minutes)}:{(seconds <= 10 ? "0" + seconds : seconds)}");
        }

        public void Exercise5()
        {
            System.Console.Write("Year: ");
            if(!ushort.TryParse(System.Console.ReadLine(), out ushort year))
            {
                System.Console.Write("Invalid value. Try again: ");
            }

            if(year % 4 == 0)
            {
                System.Console.WriteLine(366);
            }
            else
            {
                System.Console.WriteLine(365);
            }
        }
    }
}