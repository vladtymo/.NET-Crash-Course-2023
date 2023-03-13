namespace dz_7
{
    internal class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public decimal Salary { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Surname: {Surname}, BirdthDate: {BirthDate}, Salary: {Salary}";
        }
    }
}
