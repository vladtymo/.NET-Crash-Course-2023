namespace lesson_6_constructors
{
    class Car
    {
        private readonly string model;
        private readonly int year;
        private int? mileage;
        private float? engineCapacity;
        private int price;
        private string status;
        private const int minYear = 1886;
        public Car(string model, int year, int price)
        {
            if (model.Length > 0 && year >= minYear && price >= 0)
            {
                this.model = model;
                this.year = year;
                this.price = price;
                mileage = null;
                engineCapacity = null;
            }
            else
                status = "Дані вказано не коректно, тому інформацію про об'єкт зберегти не вдалось...";
        }

        public Car(string model, int year, int price, int mileage, float engineCapacity)
        {
            if (model.Length > 0 && year >= minYear && price >= 0 && mileage >= 0 && engineCapacity >= 0)
            {
                this.model = model;
                this.year = year;
                this.price = price;
                this.mileage = mileage;
                this.engineCapacity = engineCapacity;
            }
            else
                status = "Дані вказано не коректно, тому інформацію про об'єкт зберегти не вдалось...";
        }

        public bool CheckStatus()
        {
            if (status == null)
                return true;
            else
                return false;
        }
        public void ChangeMileage(int changeValue)
        {
            if (mileage == null)
                mileage = changeValue;
            else
                mileage += changeValue;
        }
        public void ChangePrice(int changeValue)
        {
            price += changeValue;
        }
        public void ShowStatus()
        {
            Console.WriteLine(status);
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Модель: {model}\n" +
                $"Рік випуску {year}\n" +
                $"Ціна: {price}\n" +
                $"Пробіг автомобіля: {(mileage == null ? "автомобіль новий, або не вказано" : mileage)}\n" +
                $"Об'єм двигуна: {(engineCapacity == null ? "не вказано" : mileage)}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;


            Car[] carObjects = new Car[4];
            //--------виклик першого конструктора
            carObjects[0] = new Car("Mazda 6", 2020, 26500);
            //--------некоректно введені данні
            carObjects[1] = new Car("", 2020, -26500);
            carObjects[2] = new Car("Toyota RAV4", 1867, 41000);
            //--------виклик другого конструктора
            carObjects[3] = new Car("Toyota RAV4", 2021, 41000, 23000, 2.5F);

            Console.Write("Введіть номер автомобіля який хочете обрати: ");
            int a = int.Parse(Console.ReadLine()) - 1;
            Console.WriteLine("Автомобіль №" + (a+1) + "\nІнформація про ваш автомобіль:");
            if (carObjects[a].CheckStatus())
                carObjects[a].ShowInfo();
            else
                carObjects[a].ShowStatus();
            Console.WriteLine("\n");

            carObjects[a].ChangeMileage(35);
            carObjects[a].ChangePrice(1000);

            Console.WriteLine("Автомобіль №" + (a+1) + "\nІнформація про ваш автомобіль:");
            if (carObjects[a].CheckStatus())
                carObjects[a].ShowInfo();
            else
                carObjects[a].ShowStatus();
        }
    }
}