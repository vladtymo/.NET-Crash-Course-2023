using System.Drawing;

namespace _10_classes_part_2
{
    class Rectangle
    {
        private int height;
        private int width;

        public Rectangle() { }
        public Rectangle(int size) 
        {
            this.width = size;
            this.height = size;
        }
        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public void Print(char filler = '#') // default parameter value
        {
            for (int h = 0; h < height; h++)
            {
                Console.WriteLine(new string(filler, width));
            }
        }
    }

    class Student
    {
        // fields (common, readonly, constant)
        private readonly string name;
        private string specialization;
        private float? averageMark;
        private readonly DateOnly birthdate; // can initialize or set in constructors

        private const int maxMarkValue = 12; // initialize only

        // constructors
        //public Student() { }
        public Student(string name, string specialization, DateOnly birthdate)
        {
            // this - reference to itself
            this.name = name;
            this.specialization = specialization;
            this.birthdate = birthdate;
            this.averageMark = null;
        }
        public Student(string n, string s, DateOnly d, float m)
        {
            name = n;
            specialization = s;
            birthdate = d;
            averageMark = m;
        }

        public void SetAverageMark(float newValue)
        {
            if (newValue > 0 && newValue <= maxMarkValue)
                averageMark = newValue;
        }

        public void ShowStatus()
        {
            if (averageMark == null)
                Console.WriteLine("No assigned marks yet!");
            else
            {
                if (averageMark >= 7)
                    Console.WriteLine("Good student!");
                else
                    Console.WriteLine("Bad student!");
            }
        }

        public void ShowShortInfo()
        {
            Console.WriteLine($"Student: {name} {specialization}, " +
                $"avg mark: {(averageMark == null ? "empty" : averageMark)}");
        }
        public void ShowFullInfo()
        {
            Console.WriteLine($"Student full information: {name} {specialization}, " +
                $"avg mark: {(averageMark == null ? "empty" : averageMark)}\n" +
                $"Birthdate: {birthdate:yyyy.MM.dd}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // invoke constructors
            Rectangle rect = new Rectangle(20, 10);

            rect.Print();
            rect.Print('+');

            // initialization vs assignment

            int a = 10; // initialization

            a = 20;     // assignment
            ++a;        // assignment
            a += 5;     // assignment

            // create instance (allocate memory)
            //Student st = new Student(); // no default constructor
            Student st1 = new Student("Volodya", "Software Engineer", new DateOnly(2005, 2, 15));

            st1.ShowShortInfo();

            st1.SetAverageMark(8.9F);
            st1.SetAverageMark(-60); // ignore

            st1.ShowFullInfo();

            st1.ShowStatus();

            Student st2 = new Student("Igor", "Designer", new DateOnly(1998, 5, 1), 10.5F);

            st2.ShowShortInfo();
        }
    }
}