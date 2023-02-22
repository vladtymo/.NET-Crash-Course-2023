
namespace task_7
{
    internal class Employee
    {

        private string name;
        private decimal salary;
        private string surname;
        private DateTime birthDate;

        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public decimal Salary { get; set; }

        public Employee(string name, string surname, decimal salary, DateTime birthDate)
        {
            this.name = name;
            this.surname = surname;
            this.salary = salary;   
            this.birthDate = birthDate;

        }
        public override string ToString() => $"Full name: {surname} {name} ({birthDate})";

    }
}
