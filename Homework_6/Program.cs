namespace Task
{
    internal class Program
    {
        class Car 
        {
            private readonly string brand;
            private readonly string model;
            private readonly float? maxSpeed;
            private readonly int yearOfRelease;
            private float? price;
            private float? T;
            private float? RPM;
            private const int F = 5252;

            public Car(string brand, string model, float maxSpeed, int yearOfRelease)
            {
                if(brand is not String || model is not String || maxSpeed < 0 || yearOfRelease < 1900) {
                    Console.WriteLine("Invalid data!");
                }

                this.brand = brand;
                this.model = model; 
                this.maxSpeed = maxSpeed;
                this.yearOfRelease = yearOfRelease; 
                this.price = null;
                this.T = null;
                this.RPM = null;
            }

            public Car(string brand, string model, float maxSpeed, int yearOfRelease, float price) 
            {
                if (brand is not String || model is not String || maxSpeed < 0 || yearOfRelease < 1900 || price < 0)
                {
                    Console.WriteLine("Invalid data!");
                }
                this.brand = brand;
                this.model = model;
                this.maxSpeed = maxSpeed;
                this.yearOfRelease = yearOfRelease;
                this.price = price;
                this.T = null;
                this.RPM = null;
            }

            public Car(string brand, string model, float maxSpeed, int yearOfRelease, float price, float T, float RPM)
            {
                if (brand is not String || model is not String || maxSpeed < 0 || yearOfRelease < 1900 || price < 0 || T < 0 || RPM < 0)
                {
                    Console.WriteLine("Invalid data!");
                }
                this.brand = brand;
                this.model = model;
                this.maxSpeed = maxSpeed;
                this.yearOfRelease = yearOfRelease;
                this.price = price;
                this.T = T;
                this.RPM = RPM;
            }

            public void ShowShortInfo() 
            {
                Console.WriteLine($"Car: \n" +
                    $"\t{brand} {model}\t Max speed: {maxSpeed},\tDate of release: {yearOfRelease}");
            }

            public void ShowExtendedInfo() 
            {
                if(maxSpeed > 250 && price > 100000 && yearOfRelease > 2000) {
                    Console.WriteLine($"Car: \n" +
                    $"\t{brand} {model}\t Max speed: {maxSpeed},\tDate of release: {yearOfRelease}\t Price: {price}\n" +
                    $"So u have a modern luxury sportcar! Congratulation, u like expensive speed!");
                }

                else if (maxSpeed < 250 && price > 100000 && yearOfRelease > 2000)
                {
                    Console.WriteLine($"Car: \n" +
                    $"\t{brand} {model}\t Max speed: {maxSpeed},\tDate of release: {yearOfRelease}\t Price: {price}\n" +
                    $"So u have a modern luxury car! Congratulation, u really like expencive comfort!");
                }

                else if (maxSpeed > 250 && price < 100000 && yearOfRelease > 2000)
                {
                    Console.WriteLine($"Car: \n" +
                    $"\t{brand} {model}\t Max speed: {maxSpeed},\tDate of release: {yearOfRelease}\t Price: {price}\n" +
                    $"So u have a modern sportcar! Congratulation, rider!");
                }

                else if (maxSpeed > 250 && price > 100000 && yearOfRelease < 2000)
                {
                    Console.WriteLine($"Car: \n" +
                    $"\t{brand} {model}\t Max speed: {maxSpeed},\tDate of release: {yearOfRelease}\t Price: {price}\n" +
                    $"So u have an old luxury sportcar! Congratulation, connoisseur of the art of speed!");
                }

                else if (maxSpeed < 250 && price < 100000 && yearOfRelease > 2000)
                {
                    Console.WriteLine($"Car: \n" +
                    $"\t{brand} {model}\t Max speed: {maxSpeed},\tDate of release: {yearOfRelease}\t Price: {price}\n" +
                    $"So u have a modern car! Congratulation, u really unassuming!");
                }

                else if (maxSpeed < 250 && price > 100000 && yearOfRelease < 2000)
                {
                    Console.WriteLine($"Car: \n" +
                    $"\t{brand} {model}\t Max speed: {maxSpeed},\tDate of release: {yearOfRelease}\t Price: {price}\n" +
                    $"So u have an old luxury car! Congratulation, very good choice, maestro!");
                }

                else if (maxSpeed > 250 && price < 100000 && yearOfRelease < 2000)
                {
                    Console.WriteLine($"Car: \n" +
                    $"\t{brand} {model}\t Max speed: {maxSpeed},\tDate of release: {yearOfRelease}\t Price: {price}\n" +
                    $"So u have an old sportcar! Congratulation, be carefull on the road!");
                }

                else if (maxSpeed < 250 && price < 100000 && yearOfRelease < 2000)
                {
                    Console.WriteLine($"Car: \n" +
                    $"\t{brand} {model}\t Max speed: {maxSpeed},\tDate of release: {yearOfRelease}\t Price: {price}\n" +
                    $"So u have an old car! Congratulation, u have a bucket on wheels!");
                }

            }

            public void CalculateHorsePower() 
            {
                if (T == null || RPM == null) 
                {
                    Console.WriteLine("I can't calculate HorsePower without data!");
                }
                else { Console.WriteLine($"HorsePower = {(T*RPM)/F}"); }
            }


        }
        static void Main(string[] args)
        {
            Car bmw = new Car("bmw", "m5", 280, 2021);
            bmw.ShowShortInfo();
            bmw.ShowExtendedInfo();
            bmw.CalculateHorsePower();

            Car audi = new Car("audi", "rs7", 300, 2022, 200000, 6000, 20);
            audi.ShowShortInfo();
            audi.ShowExtendedInfo();
            audi.CalculateHorsePower();
        }
    }
}