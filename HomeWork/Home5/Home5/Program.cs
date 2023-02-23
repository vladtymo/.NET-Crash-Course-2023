namespace Home5
{
    using System;

    class Car
    {
        // Основні характеристики автомобіля
        private string make;
        private string model;
        private int? year;
        private decimal? price;
        private readonly bool isNew;

        // Конструктори
        public Car(string make, string model, int year, decimal price)
        {
            SetMake(make);
            SetModel(model);
            SetYear(year);
            SetPrice(price);
            isNew = false;
        }

        public Car(string make, string model, int year)
        {
            SetMake(make);
            SetModel(model);
            SetYear(year);
            isNew = true;
        }

        public Car()
        {
            isNew = true;
        }

        // Методи доступу до закритих полів
        public string GetMake()
        {
            return make;
        }

        public void SetMake(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Make cannot be null or empty");
            }
            make = value;
        }

        public string GetModel()
        {
            return model;
        }

        public void SetModel(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Model cannot be null or empty");
            }
            model = value;
        }

        public int? GetYear()
        {
            return year;
        }

        public void SetYear(int? value)
        {
            if (value < 1900 || value > DateTime.Now.Year + 1)
            {
                throw new ArgumentException("Year is invalid");
            }
            year = value;
        }

        public decimal? GetPrice()
        {
            return price;
        }

        public void SetPrice(decimal? value)
        {
            if (value <= 0)
            {
                throw new ArgumentException("Price must be greater than zero");
            }
            price = value;
        }

        // Методи управління класом
        public bool IsNew()
        {
            return isNew;
        }

        public string GetDescription()
        {
            return $"{make} {model} ({year})";
        }

        public void PrintPrice()
        {
            Console.WriteLine($"${price}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = new Car[3];

            // Створення об'єктів з різними конструкторами
            cars[0] = new Car("Toyota", "Corolla", 2021, 18000);
            cars[1] = new Car("Honda", "Civic", 2019);
            cars[2] = new Car();

            // Виведення інформації про кожен автомобіль
            foreach (Car car in cars)
            {
                Console.WriteLine(car.GetDescription());

                if (car.GetPrice() != null)
                {
                    car.PrintPrice();
                }

                Console.WriteLine($"Is new? {car.IsNew()}");

                Console.WriteLine();
            }

            // Зміна деяких характеристик
            cars[0].SetPrice(20000);
            cars[1].SetYear(2020);
            cars[2].SetMake("Ford");
            cars[2].SetModel("Mustang");
            cars[2].SetYear(1965);

            // Повторне виведення інформації про кожен автомобіль
            foreach (Car car in cars)
            {
                Console.WriteLine(car.GetDescription());

                if (car.GetPrice() != null)
                {
                    car.PrintPrice();
                }

                Console.WriteLine($"Is new? {car.IsNew()}");

                Console.WriteLine();
            }
        }
    }
}