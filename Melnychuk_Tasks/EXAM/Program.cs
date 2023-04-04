using System;
using System.Diagnostics;
using System.Globalization;


namespace Exam
{
    internal class Program
    {
        static void Main(string[] args){}


        public enum Names 
        {
            Alexander = 1,
            Dale = 2,
            Clyde = 3,
            Ian = 4,
            Max = 5,
            Justine = 6,
            Merry = 7,
            Nellie = 8,
            Natalia = 9,
            Louisa = 10,
            Mabel = 11,
            Margaret = 12

        }

        public enum Surnames
        {
            Adamson = 1,
            Bush = 2,
            Cooper = 3,
            Ford = 4,
            King = 5,
            Wesley = 6,
            Wood = 7,
            Smith = 8
   
        }
        

        #region interface
        public interface IEditor
        {
            void Edit();
        }
        #endregion

        #region salon
        class BeautySalon
        {

            public string Name { get; set; } = "Victoria";

            public List<Person> Persons { get; set; } = new List<Person>();

            public List<Product> Products { get; set; } = new List<Product>();

            public List<Service> Services { get; set; } = new List<Service>();

            public List<Order> Orders { get; set; } = new List<Order>();

            public void ShowItems<T>(List<T> items, Action<T> printMethod)
            {
                Console.WriteLine($"Список елементів типу {typeof(T).Name}:");
                foreach (T item in items)
                {
                    printMethod(item);
                }
            }

            //Console.Clear();
            //////////////////////////////
            public void ShowPerson(){ShowItems(Persons, p => p.PrintInfo());}
            public void AddPerson()
            {
                Console.Clear();
                ShowPerson();
                Console.WriteLine("Виберіть кого ви хочете додати:");
                Console.Write("Якщо хочете додати Майстра введіть 1/Клієнта 2:");
                int b = int.Parse(Console.ReadLine());
                if (b == 1)
                {
                    Master master = new Master();
                    Persons.Add(master);
                }
                else if (b == 2)
                {
                    Console.WriteLine("Введіть кількість грошей:");
                    int money = int.Parse(Console.ReadLine());
                    Client client = new Client(money);
                    Persons.Add(client);
                }
                Console.Clear();
            }
            public void RemovePerson()
            {
                Console.Clear();
                ShowPerson();
                Console.WriteLine("Виберіть кого ви хочете видалити");
                Console.Write($"Введіть індекс:");
                int idRemovePerson = int.Parse(Console.ReadLine());
                Persons.RemoveAt(idRemovePerson);
                Console.Clear();
            }

            public void ShowProduct() { ShowItems(Products, p => p.PrintInfo()); }
            public void AddProduct()
            {
                Console.Clear();

                ShowProduct();
                Console.WriteLine("Введіть нове ім'я:");
                string name = Console.ReadLine();
                Console.WriteLine("Введіть нову варітсть:");
                int price = int.Parse(Console.ReadLine());
                Product product = new Product(name,price);
                Products.Add(product);
                Console.Clear();
            }
            public void RemoveProduct()
            {
                Console.Clear();
                ShowProduct();
                Console.WriteLine("Виберіть що ви хочете видалити");
                Console.Write($"Введіть індекс:");
                int idRemoveProduct = int.Parse(Console.ReadLine());
                Products.RemoveAt(idRemoveProduct);
                Console.Clear();
            }
            //////////////////////////////
            public void ShowService() { ShowItems(Services, p => p.PrintInfo()); }
            public void AddService()
            {
                Console.Clear();
                ShowService();
                Console.WriteLine("Виберіть що ви хочете додати:");
       
                Console.Write("Якщо хочете додати Haircut введіть 1/Coloring 2/Manicure 3/CosmeticProcedure 4 :");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Введіть прайс :");
                int price = int.Parse(Console.ReadLine());
                Console.WriteLine("Введіть тип:");
                string type = Console.ReadLine();
                switch (b)
                {
                    case 1:
                        Haircut haircut = new Haircut(type, price);
                        Services.Add(haircut);
                        break;
                    case 2:
                        Coloring coloring = new Coloring(type, price);
                        Services.Add(coloring);
                        break;
                    case 3:
                        string additionalServices = Console.ReadLine();
                        Manicure manicure = new Manicure(type, price, additionalServices);
                        Services.Add(manicure);
                        break;
                    case 4:
                        int duration = int.Parse(Console.ReadLine());
                        CosmeticProcedure cosmeticProcedure = new CosmeticProcedure(type, price, duration);
                        Services.Add(cosmeticProcedure);
                        break;
                    default: break;
                }
                Console.Clear();
            }
            public void RemoveService() 
            {
                Console.Clear();
                ShowService();
                Console.WriteLine("Виберіть що ви хочете видалити");
                Console.Write($"Введіть індекс:");
                int idRemoveService = int.Parse(Console.ReadLine());
                Services.RemoveAt(idRemoveService);
                Console.Clear();
            }
            //////////////////////////////
            public void ShowOrder() { ShowItems(Orders, p => p.PrintInfo()); }
            public void AddOrder()
            {
                Console.Clear();
                ShowOrder();
                Console.WriteLine("Виберіть клієнта в списку усіх персон:");
                ShowPerson();
                int c = int.Parse(Console.ReadLine());
                Client client = (Client)Persons[c];
                ////////
                Console.WriteLine("Виберіть послугу в списку усіх персон:");
                ShowService();
                int s = int.Parse(Console.ReadLine());
                Service service = Services[s];
                ////////
                Console.WriteLine("Введіть дату (format: dd/MM/yyyy): ");
                string input = Console.ReadLine();
                DateTime date = DateTime.ParseExact(input, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                //////
                Console.WriteLine("Виберіть клієнта в списку усіх персон:");
                ShowPerson();
                int p = int.Parse(Console.ReadLine());
                Master master = (Master)Persons[c];


                Order order = new Order(client, service, date, master);
                Console.Clear();
            }
            public void RemoveOrder()
            {
                Console.Clear();
                ShowOrder();
                Console.WriteLine("Виберіть що ви хочете видалити");
                Console.Write($"Введіть індекс:");
                int idRemoveOrder = int.Parse(Console.ReadLine());
                Orders.RemoveAt(idRemoveOrder);
                Console.Clear();
            }

        }


        public class Order
        {
            public Client Client { get; set; }
            public Service Service { get; set; }
            public DateTime Date { get; set; }
            public Master Performer { get; set; }

            public Order(Client client, Service service, DateTime date, Master performer)
            {
                Client = client;
                Service = service;
                Date = date;
                Performer = performer;
            }

            public void PrintInfo()
            {
                Console.WriteLine($"Клієнт: {Client.Name} {Client.Surname} | Послуга: {Service.Name} | Дата: {Date.ToString("dd/MM/yyyy")} | Виконавець: {Performer.Name} {Performer.Surname}");
            }
        }

        #endregion

        #region services
        public abstract class Service : IEditor
        {
            public string Name { get; set; }
            public int Price { get; set; }
            public string Type { get; set; }
            public Service(string name, int price, string type)
            {
                Name = name;
                Price = price;
                Type = type;
            }

            public virtual void PrintInfo() 
            {
                Console.WriteLine($"{Name}: {Price} грн");
            }
            public virtual void Edit()
            {
                Console.WriteLine("Редагування {0}",Name);
                Console.Write("Введіть но назву:");
                this.Name = Console.ReadLine();
                Console.Write("\nВведіть нову ціну:");
                this.Price = int.Parse(Console.ReadLine());
            }   

        }


        class Haircut : Service
        {
            public Haircut(string type, int price) : base("Стрижка", price, type) { }

            public override void PrintInfo()
            {
                Console.WriteLine($"{Name} ({Type}): {Price} грн");
            }

            public override void Edit()
            {
                base.Edit();
                Console.Write("\nВведіть новий тип:");
                this.Type = Console.ReadLine();
            }  
        }
        class Coloring : Service
        {
            public Coloring(string type, int price) : base("Фарбування", price, type) { }

            public override void PrintInfo()
            {
                Console.WriteLine($"{Name} ({Type}): {Price} грн");
            }
       
            public override void Edit() 
            {
                base.Edit();
                Console.Write("\nВведіть новий тип:");
                this.Type = Console.ReadLine();
            }
        }
        class Manicure : Service
        {
            public string AdditionalServices { get; set; } 

            public Manicure(string type, int price, string additionalServices) : base("Манікюр", price, type)
            {
                AdditionalServices = additionalServices;
            }

            public override void PrintInfo()
            {
                Console.WriteLine($"{Name} ({Type}): {Price} грн, Додаткові послуги: {AdditionalServices}");
            }

            public override void Edit() 
            {
                base.Edit();
                Console.Write("\nВведіть новий тип:");
                this.Type = Console.ReadLine();
                Console.Write("\nВведіть додаткові параметри:");
                this.AdditionalServices = Console.ReadLine();
            }

        }
        class CosmeticProcedure : Service
        { 
            public int Duration { get; set; } 

            public CosmeticProcedure(string type, int duration, int price) : base("Косметична процедура", price, type)
            {
                Duration = duration;
            }

            public override void PrintInfo()
            {
                Console.WriteLine($"{Name} ({Type}, {Duration} хв): {Price} грн");
            }
           
            public override void Edit() 
            {
                base.Edit();
                Console.Write("\nВведіть новий тип:");
                this.Type = Console.ReadLine();
                Console.Write("\nВведіть нову тривалість процедури:");
                this.Duration = int.Parse(Console.ReadLine());
            }         
        }
        #endregion

        #region persons
        public abstract class Person : IEditor
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public string PhoneNumber { get; set; }
            public string Type { get; set; }
            public virtual void Edit()
            {                
                PrintInfo();
                Console.WriteLine("Введіть нове ім'я:");
                Name = Console.ReadLine();
                Console.WriteLine("Введіть нове прізвище:");
                Surname = Console.ReadLine();
                Console.WriteLine("Введіть новий номер:");
            }
            public virtual void PrintInfo()
            { 
                Console.WriteLine($"Type: {Type}| Name: {Name}\t| Surname: {Surname}\t| Phonenumber: {PhoneNumber}\t| ");

            }

            public Person()
            {
                Random rand = new Random();
                Names randomName = (Names)Enum.GetValues(typeof(Names)).GetValue(rand.Next(Enum.GetValues(typeof(Names)).Length));
                Name = randomName.ToString();

                Surnames surname = (Surnames)Enum.GetValues(typeof(Surnames)).GetValue(rand.Next(Enum.GetValues(typeof(Surnames)).Length));
                Surname = surname.ToString();

                PhoneNumber = "+380"; 
                PhoneNumber += rand.Next(66, 99).ToString(); 
                PhoneNumber += rand.Next(1000000, 9999999).ToString();

            }
        }

        public class Client : Person
        {
            public Client(int money) : base()
            {
                Type = "Client";
                Money = money;
            }
            public int Money { get; set; }

            public override void Edit()
            {
                base.Edit();
                Console.WriteLine("Введіть кількість грошей:");
                Money = int.Parse(Console.ReadLine());
            }
        }
        public class Master : Person
        {
            public Master(): base()
            {
                Type = "Master"; 
            }
            public void Work()
            {
                Console.WriteLine($"Майстер {Name} працює.");
            }
        }
        #endregion

        #region products
        public  class Product : IEditor
        {
            public string Name { get; set; }
            public int Price { get; set; }

            public Product(string name,int price)
            {
                Name = name;
                Price = price;
            }
            public void Edit()
            {
                PrintInfo();
                Console.WriteLine("Введіть нове ім'я:");
                Name = Console.ReadLine();
                Console.WriteLine("Введіть нову варітсть:");
                Price = int.Parse( Console.ReadLine() );
            }
            public  void PrintInfo()
            {
                Console.WriteLine($"Name: {Name}\t| Price: {Price}\t| ");
            }
        }
        #endregion

    }
}