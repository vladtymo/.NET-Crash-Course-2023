using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Task
{
    internal abstract class Person
    {
        public  string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Person(string firstName,string lastName, string email)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email=email;
        }
        public abstract void DoWork();
        public virtual void PrintInfo()
        {
           Console.WriteLine($"Person {FirstName},{LastName}, email: {Email}");
        }

    }
}
