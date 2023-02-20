using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Car[] cars = new Car[3];
            cars[0] = new Car("Ford Shelby GT 500", 1969);
            cars[1] = new Car("Koenigsegg Agera RS", 2012, 415);
            cars[2] = new Car("Ford GT40", 1970, 240, false);

            foreach (Car car in cars)
            {
                car.Car_info();
                car.UpSpeed(random.Next(1,100));
                car.ChangeYear(random.Next(1998, 2023));
                Console.WriteLine("Changed\n\n");
                car.Car_info();
                Console.WriteLine();
            }
        }
    }
}
