namespace _13_inheritance
{
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateOnly Birthdate { get; }
        public string? Country { get; set; }
        public string FullName => $"{Name} {Surname}";

        public Person(string name, string surname, DateOnly birthdate, string? country)
        {
            Name = name;
            Surname = surname;
            Birthdate = birthdate;
            Country = country;
        }

        public void Move()
        {
            Console.WriteLine("I am moving...");
        }

        public void ShowInfo()
        {
            Console.WriteLine(new String('-', 33));
            Console.WriteLine($"Full name: {FullName}\n" +
                $"Birthdate: {Birthdate.ToLongDateString()}\n" +
                $"Country: {Country ?? "no data"}");
        }
    }

    // inheritance: class Child : Base
    class Student : Person
    {
        public float AverageMark { get; set; }
        public string Specialization { get; set; }

        public Student(string name, string surname, DateOnly birthdate, string? country, float avgMark, string spec)
            : base(name, surname, birthdate, country)
        {
            AverageMark = avgMark;
            Specialization = spec;
        }

        public void Study()
        {
            Console.WriteLine("I am studing now...");
        }

        // new - hides the base class method
        public new void ShowInfo()
        {
            // base - reference to the base class
            base.ShowInfo();
            Console.WriteLine($"Average mark: {AverageMark}\n" +
                $"Specialization: {Specialization}");
        }
    }

    class Aspirant : Student
    {
        public string Diploma { get; set; }
        public string Subject { get; set; }

        public Aspirant(string name, string surname, DateOnly birthdate, string? country, float avgMark, string spec, string diploma, string subject)
            : base(name, surname, birthdate, country, avgMark, spec)
        {
            Diploma = diploma;
            Subject = subject;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Viktoria", "Soder", new DateOnly(2010, 4, 7), "Ukraine");
            person.ShowInfo();
            person.Move();

            Student student = new Student("Igor", "Breba", new DateOnly(1995, 1, 19), "Poland", 9.4F, "Design");
            student.ShowInfo();
            student.Study();

            Aspirant aspirant = new Aspirant("Igor", "Breba", new DateOnly(1995, 1, 19), "Poland", 9.4F, "Design", "Bacelor diploma", ".NET");
            aspirant.ShowInfo();
        }
    }
}