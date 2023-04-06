using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Task
{
    internal class Subject
    {
        public string Name { get; set; }
        public int NumberOfStudyHours { get; set; }
        public Subject(string name, int numberOfStudyHours)
        {
            this.Name = name;
            this.NumberOfStudyHours = numberOfStudyHours;
        }
        public override string ToString()
        {
            return $"Subject \" {Name}\" with {NumberOfStudyHours} hours to study";
        }
        
    }
}
