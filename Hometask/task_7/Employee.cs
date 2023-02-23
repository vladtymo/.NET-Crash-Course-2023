
namespace task_7
{
    internal class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public decimal Salary { get; set; }

        public Employee(string name, string surname, decimal salary, DateTime birthDate)
        {
            Name = name;
            Surname = surname;
            Salary = salary;   
            BirthDate = birthDate;

        }
        public override string ToString() => $"Full name: {Surname} {Name} - {BirthDate}";

    }
}
