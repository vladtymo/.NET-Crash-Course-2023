using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Car
    {
        private readonly string car_name;
        private int car_year;
        private int? car_speed = null;
        private const int car_maxprice = 5000000;
        private bool? car_fixed = null;
        private int base_speed = 120;


        public Car(string car_name, int car_year, int car_speed, bool? car_fixed)
        {
            this.car_name = car_name;
            this.car_year = car_year;
            this.car_speed = car_speed;
            this.car_fixed = car_fixed;
        }
        public Car(string car_name, int car_year, int car_speed)
        {
            this.car_name = car_name;
            this.car_year = car_year;
            this.car_speed = car_speed;
        }
        public Car(string car_name, int car_year)
        {
            this.car_name = car_name;
            this.car_year = car_year;
        }

        public void Car_info()
        {
            Console.WriteLine($"Car named: {car_name}.\n" +
             $"Car year: {car_year}\n" +
             $"Car speed: {(car_speed != null ? car_speed.ToString() : base_speed.ToString())}\n" +
             $"Car is repaired?: {(car_fixed != null ? car_fixed.ToString() : "Unknown")}");
        }

        public void UpSpeed(int speed)
        {
            if (car_speed == null)
            {
                base_speed += speed;
            }
            if (speed > 0)
            {
                car_speed += speed;
            }
            else
            {
                Console.WriteLine("I cant up speed to negative value");
            }
        }

        public void ChangeYear(int car_year)
        {
            this.car_year = car_year;
        }

        public bool isFixed(bool fix)
        {
            if (fix == true){
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
