using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crash_course_system_interfaces
{
    internal class Director : ICloneable
    {
        //public delegate Action   die;
        public string FullName { get; set; }
        public DateOnly DateOfBirth { get; set; }


        public Director(string fullName, DateOnly dateOfBirth)
        { 
            FullName= fullName;
            DateOfBirth= dateOfBirth;
        }

        public object Clone()
        {
            var directorClone = (Director)this.MemberwiseClone();
            return directorClone;
        }

        public new void ToString()
        {
            Console.WriteLine("Direcror info:\n" +
                $"Full name: {FullName} \n" +
                $"Date: {DateOfBirth}\n" );
        }

    }
}
