using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_10_system_interfaces
{
    internal class Director: ICloneable
    {
       public string FirstName{get; set;}
       public string LastName{get; set;}

       public Director(string FirstName, string LastName)
       {
           this.FirstName = FirstName;
           this.LastName = LastName;
       }

       public object Clone()
       {
          return new Director(FirstName, LastName);
       }

       public override string ToString()
       {
           return $"Director: {FirstName} {LastName}";
       }
    }
}
