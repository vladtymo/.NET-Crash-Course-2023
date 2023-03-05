using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    class Director : ICloneable
    {
        public Director(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        public string FirstName { get; } 
        public string LastName { get; }

        public object Clone()
        {
            var clone = (Director)this.MemberwiseClone();
            return clone;
        }

        public override string ToString()
        {
            return $"FirstName {FirstName} LastName {LastName}";
        }
    }
}
