using System;


public class Task_5
{

    class Car
    {
        private readonly string car_brand;
        private double engine_capacity;
        private string type_of_fuel;
        private double? dispersal = null;
        private int power;
        private bool turbo;
        private string transmission;

        public Car()
        {
            car_brand = "Noname";
        }

        public Car(string car_band, double engine_capacity, string type_of_fuel, bool turbo, string transmission, double? dispersal)
        {
            this.car_brand = car_band;
            this.engine_capacity = engine_capacity;
            this.type_of_fuel = type_of_fuel;
            this.turbo = turbo;
            this.transmission = transmission;
            this.dispersal = dispersal;
        }

        public void Set_characteristics(double engine_capacity, string type_of_fuel, bool turbo, string transmission, double? dispersal)
        {
            this.engine_capacity = engine_capacity;
            this.type_of_fuel = type_of_fuel;
            this.turbo = turbo;
            this.transmission = transmission;
            this.dispersal = dispersal;

        }
        public void Calculate_power()
        {

            if (type_of_fuel == "diesel")
            {
                if (turbo)
                {
                    power = (int)(engine_capacity * 70);
                }
                else { power = (int)(engine_capacity * 45); }
            }
            else if (type_of_fuel == "petrol")
            {
                if (turbo)
                {
                    power = (int)(engine_capacity * 90);
                }
                else { power = (int)(engine_capacity * 60); }
            }
        }


        public void ShowCar()
        {
            Console.WriteLine($"\tBrand: {car_brand}| engine capacity: {engine_capacity}L| type of fuel: {type_of_fuel}| turbo: { (turbo ? '+':'-')}| transmission: {transmission}| dispersal 0-100: {(dispersal==null? "the car cannot accelerate to 100": (dispersal + "sec"))}| {(power==0?"" : "power :"+power)} ");
        }
    }





    public static void Main(string[] args)
    {

        Car car = new Car();

        Car car1 = new Car("Audi", 3.0, "diesel", true, "manual", 6.3);


        car.Set_characteristics(2.2, "petrol", false, "auto", 8.7);

        car.ShowCar();
        car1.ShowCar();
        car.Calculate_power();
        car1.Calculate_power();
        car.ShowCar();
        car1.ShowCar();



    }





}