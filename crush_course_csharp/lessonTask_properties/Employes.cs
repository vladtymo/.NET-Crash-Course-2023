using System.Diagnostics;

namespace lessonTask_properties
{
    internal class Employes
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public decimal Salary { get; set; }
        public override string ToString()
        {
            return $"Name: {Name}\nSurname: {Surname}\n" +
                $"BirthDate: {BirthDate}\nSalary: {Salary}";
        }
    }
}
