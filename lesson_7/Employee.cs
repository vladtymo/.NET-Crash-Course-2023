using System;

namespace Structure{
    class Employee{
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public decimal Salary { get; set; }
        public Employee(string name, string surname, DateTime birthDate, decimal salary){
            Name = name;
            Surname = surname;
            BirthDate = birthDate;
            Salary = salary;
        }
        public override string ToString(){
            return $"Employee: {Name} {Surname}";
        }
    }
}
