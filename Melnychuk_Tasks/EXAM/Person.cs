using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Exam.Program;

namespace EXAM
{
    public abstract class Person : IEditor
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string Type { get; set; }
        public virtual void Edit()
        {
            PrintInfo();
            Console.Write("\n\t\tВведіть нове ім'я: ");
            Name = Console.ReadLine();
            Console.Write("\n\t\tВведіть нове прізвище: ");
            Surname = Console.ReadLine();
            Console.Write("\n\t\tВведіть новий номер: ");
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Type: {Type}| Name: {Name}\t| Surname: {Surname}\t| Phonenumber: {PhoneNumber}\t| ");

        }

        public Person()
        {
            Random rand = new Random();
            Names randomName = (Names)Enum.GetValues(typeof(Names)).GetValue(rand.Next(Enum.GetValues(typeof(Names)).Length));
            Name = randomName.ToString();

            Surnames surname = (Surnames)Enum.GetValues(typeof(Surnames)).GetValue(rand.Next(Enum.GetValues(typeof(Surnames)).Length));
            Surname = surname.ToString();

            PhoneNumber = "+380";
            PhoneNumber += rand.Next(66, 99).ToString();
            PhoneNumber += rand.Next(1000000, 9999999).ToString();

        }
    }
}
