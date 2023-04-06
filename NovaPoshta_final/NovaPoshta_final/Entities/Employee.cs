using Microsoft.EntityFrameworkCore.Metadata.Internal;
using NovaPoshta_final.Databasae;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaPoshta_final.Entities
{
    internal class Employee : Participant
    {
        public int Salary { get; set; }
        public float AverageRate { get; set; }
        public int PostOfficeId { get; set; }
        public PostOffice PostOffice { get; set; }

        public override void ShowInfo(string surname)
        {
            DatabaseManager db = new DatabaseManager();
            Employee employee = db.GetEmployeeBySurname(surname)!;

            Console.WriteLine($"Fullname: {employee.Name} {employee.Surname}\n" +
            $"Age: {employee.Age}\n" +
            $"Salary: {employee.Salary}\n" +
            $"Avarage rate: {employee.AverageRate}");

            Menu menu = new Menu();
            menu.GoOverMainMenu();
        }
    }
}
