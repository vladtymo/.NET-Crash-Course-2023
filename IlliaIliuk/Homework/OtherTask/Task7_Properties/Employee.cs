internal class Employee
{
    public Employee() { }
    public Employee(string? name, string? surname, DateOnly birthDate, decimal salary)
    {
        Name = name;
        Surname = surname;
        BirthDate = birthDate;
        Salary = salary;
    }

    public String? Name { get; set; }
    public String? Surname { get; set; }
    public DateOnly BirthDate { get; set; }
    public decimal Salary { get; set; }
    public override String ToString() => $"{Name} {Surname} have salary {Salary}";
}