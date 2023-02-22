namespace lab_06_classes
{
    internal class lab_6_class_car
    {
        class Car
        {
            private readonly string model;
            private string? gearbox;
            private const int yearOfManufacture = 2018;
            private float maxAmountOfFuel;
            private float amountOfFuel;
            private const float maxSpeed =110;
            private float currentSpeed;

            public Car()
            {
                this.model = "Lexus RX";
                this.gearbox = "Automatic";
                this.currentSpeed = 110;
                this.maxAmountOfFuel = 60f;
                this.amountOfFuel = 25.5f;
                this.currentSpeed = 0;
            }
            public Car(string model, string gearbox, float maxAmountOfFuel)
            {
                this.model = model;
                if (gearbox != null) this.gearbox = gearbox;
                else this.gearbox = "Mechanics";
                if (maxAmountOfFuel > 0) this.maxAmountOfFuel = maxAmountOfFuel;
                else this.maxAmountOfFuel = 40f;
                this.currentSpeed = 0;
            }
            public Car(string model, string gearbox, float maxAmountOfFuel, float currentSpeed, float amountOfFuel) : this(model, gearbox, maxAmountOfFuel)
            {

                if (currentSpeed > 0 && currentSpeed <= maxSpeed) this.currentSpeed = currentSpeed;
                else if (currentSpeed > maxSpeed) this.currentSpeed = maxSpeed;
                else this.currentSpeed = 20f;
                if (amountOfFuel >= 0 && amountOfFuel <= maxAmountOfFuel) this.amountOfFuel = amountOfFuel;
                else if (amountOfFuel > maxAmountOfFuel) this.amountOfFuel = maxAmountOfFuel;
                else this.amountOfFuel = 0;
            }

            public void TheoreticalDistance(float time)
            {
                float distance = 0;
                if (time > 0)
                {
                    distance = currentSpeed * time;
                    Console.WriteLine("Theoretical distance for time(" + time + ") : " + distance);
                }
                else Console.WriteLine("Movement will not occur. Theoretical distance : " + distance);
            }

            public void CarRefueling()
            {
                amountOfFuel = maxAmountOfFuel;
            }
            public void PracicalDistance(int gasolineConsumption,float time)
            {
                float maxDistance = amountOfFuel / gasolineConsumption;
                float distance = 0;
                if (time > 0)
                {
                    distance = currentSpeed * time;
                }
                if (distance >= maxDistance) Console.WriteLine("The car will be able to drive : " + maxDistance + "km");
                else Console.WriteLine("The car will be able to drive : " + distance + "km");

            }

            public void Trevel100Km(int gasolineConsumption)
            {
                if (gasolineConsumption <= 0) gasolineConsumption = 7;
                if (amountOfFuel > 0 && amountOfFuel - gasolineConsumption >= 0)
                {
                    amountOfFuel = amountOfFuel-gasolineConsumption;
                    Console.WriteLine("The car has traveled 100 km"+
                        "\nFuel left :" + amountOfFuel);
                }
                else Console.WriteLine("There was no car movement");
            }
            public void PrintAllInfo()
            {
                Console.WriteLine("Car" +
                    "\nModel: " + model +
                    "\nYear Of Manufacture : " + yearOfManufacture +
                    "\nMax Amount Of Fuel:" + maxAmountOfFuel +
                    "\nMax Speed : " + maxSpeed +
                    "\nCurrent amount of fuel : " + amountOfFuel +
                    "\nCurrent speed : " + currentSpeed);
                Console.WriteLine();

            }
            public void PrintShortInfo()
            {
                Console.WriteLine("Car model : " + model +
                    "\nCurrent amount of fuel : " + amountOfFuel);
                Console.WriteLine();
            }
            

        }

        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.PrintAllInfo();
            Car car2 = new Car("Mitsubishi Lancer", "Mechanics", 60f);
            car2.PrintAllInfo();
            car2.TheoreticalDistance(time:15.5f);
            car2.PracicalDistance(gasolineConsumption: 12, time: 10f);
            car2.Trevel100Km(gasolineConsumption: 8);
            car2.PrintShortInfo();
            car2.CarRefueling();
            car2.PrintShortInfo();

            Car car3 = new Car("BMW M5", null, 60f,90f,45f);
            car3.PrintAllInfo();
            car2.Trevel100Km(gasolineConsumption: 19);
            car3.PrintShortInfo();
            car2.Trevel100Km(gasolineConsumption: 19);
            car2.Trevel100Km(gasolineConsumption: 19);
            
            

        }
    }
}