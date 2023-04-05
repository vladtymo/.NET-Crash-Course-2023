public abstract class Employee{
    public string Position { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public decimal Salary { get; set; }
    public DateTime HireDate { get; set; }

    public Employee(string position,string name,int age,decimal salary,DateTime hireDate){
        Name = name;
        Position = position;
        Salary = salary;
        Age = age;
        HireDate = hireDate;
    }
    public override string ToString()
    {
        return $"Name: {Name}, Position: {Position}, Salary: {Salary}\n" + 
            $"Age: {Age} HireDate: {HireDate.ToString("dd-mm-yyyy")}";
    }
}