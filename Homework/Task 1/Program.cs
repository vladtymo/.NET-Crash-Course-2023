namespace Program
{
 class Program
    {
        public static void Main(string[] args)
        {
            #region Task 1. Користувач вводить поточну дату (рік, місяць, день), відобразити її у форматі "DD/MM/YYYY".

            //short[] data = new short[3];
            //Console.Write("Enter day: ");
            //data[0] = Convert.ToInt16(Console.ReadLine());
            //Console.Write("Enter month: ");
            //data[1] = Convert.ToInt16(Console.ReadLine());
            //Console.Write("Enter year: ");
            //data[2] = Convert.ToInt16(Console.ReadLine());
            //DateTime dateTime = new DateTime(data[2], data[1], data[0]);

            //Console.WriteLine($"Date is: {dateTime.Day}/{dateTime.Month}/{dateTime.Year}");
            #endregion

            #region Task 2. Користувач вводить 2 сторони прямокутника. Вивести на екран його периметр та площу.

            //double width, height;
            //Console.Write("Enter width = ");
            //width = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter height = ");
            //height = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine($" Our parameters: width = {width}, height = {height}. Perimeter = {width * 2 + height * 2}, Area = {width * height}");
            #endregion

            #region Task 3. Користувач вводить радіус кола, програма повинна знайти його площу.

            //double radius;
            //Console.Write("Enter radius of square: ");
            //radius= Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine($"Radius = {radius}, Area = {String.Format("{0:F4}", 2 * radius * Math.PI)}");

            #endregion

            #region Task 4. Користувач вводить час в секундах, відобразити його у вигляді: HH:MM:SS
            //int seconds;
            //Console.Write("Enter value :");
            //seconds = Convert.ToInt32(Console.ReadLine());

            //TimeSpan time = TimeSpan.FromSeconds(seconds);
            

            //Console.WriteLine(time.ToString(@"hh\:mm\:ss"));
            #endregion

            #region Task 5. Користувач вводить рік, відобразити скільки днів в цьому році. 

            //short year, numberOfDays = 365;
            //Console.Write("Enter year = ");
            //year = Convert.ToInt16(Console.ReadLine());

            //bool isLeapYear = false;
            //if ((year % 4 == 0 && year % 100 == 0) || (year % 400 == 0)) isLeapYear = true;

            //if (isLeapYear)
            //{
            //    numberOfDays++;
            //}
            //Console.WriteLine($"You Enter {year}, number of days in this year is: {numberOfDays} days.");


            #endregion




            Console.ReadKey();
        }
    }
}
