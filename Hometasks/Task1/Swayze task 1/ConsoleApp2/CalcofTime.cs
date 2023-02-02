using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class CalcofTime
    {
        public void Time()
        {
            Console.Write("Enter a time of second's: ");
            int timeinseconds = int.Parse(Console.ReadLine());

            int timeinminutes = timeinseconds / 60;
            int timeinhours = 0;
            int newtimeinseconds = timeinseconds - (timeinminutes * 60);

            while (timeinminutes >= 60)
            {
                timeinhours++;
                timeinminutes -= 60;
            }

            //int newtimeinseconds = timeinseconds-(timeinhours * 60 + timeinminutes * 60);

            Console.WriteLine($"Time = {timeinhours}:{timeinminutes}:{newtimeinseconds}");
        }
    }
}
