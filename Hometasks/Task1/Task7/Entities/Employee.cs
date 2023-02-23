namespace Task7.Entities
{
    public class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public float Salary { get; set; }

        public override string ToString()
        {
            return $"Data type: {this.GetType()}; Name: {Name}; Surname: ";
        }
    }
}