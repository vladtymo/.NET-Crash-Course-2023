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

            public void ShowPerson()
            {
                Console.WriteLine("Список Персон");
                foreach (Person person in Persons)
                {
                    person.PrintInfo();
                }
            }
            public void AddPerson()
            {
                ShowPerson();
                Console.WriteLine("Виберіть кого ви хочете додати:");
            }
            public void RemovePerson()
            {
                ShowPerson();
                Console.WriteLine("Виберіть кого ви хочете видалити");
                Console.Write($"Введіть індекс:");
                int idRemovePerson = int.Parse(Console.ReadLine());
                Persons.RemoveAt(idRemovePerson);

            }

            public void ShowProduct()
            {
                Console.WriteLine("Список продуктів");
                foreach (Product product in Products)
                {
                    product.PrintInfo();
                }
            }
            public void AddProduct()
            {
                ShowProduct();
            }
            public void RemoveProduct()
            {
                ShowProduct();
                Console.WriteLine("Виберіть що ви хочете видалити");
                Console.Write($"Введіть індекс:");
                int idRemoveProduct = int.Parse(Console.ReadLine());
                Products.RemoveAt(idRemoveProduct);
            }

            public void ShowService()
            {
                Console.WriteLine("Список послуг");
                foreach (Service service in Services)
                {
                    service.PrintInfo();
                }
            }
            public void AddService() 
            {
                ShowService();
            }
            public void RemoveService() 
            {
                ShowService();
                Console.WriteLine("Виберіть що ви хочете видалити");
                Console.Write($"Введіть індекс:");
                int idRemoveService = int.Parse(Console.ReadLine());
                Services.RemoveAt(idRemoveService);
            }

            public void ShowOrder()
            {
                Console.WriteLine("Список замовлень");
                foreach (Order order in Orders)
                {
                    order.PrintInfo();
                }
            }
            public void AddOrder() 
            {
                ShowOrder();
            }
            public void RemoveOrder()
            {
                ShowOrder();
                Console.WriteLine("Виберіть що ви хочете видалити");
                Console.Write($"Введіть індекс:");
                int idRemoveOrder = int.Parse(Console.ReadLine());
                Orders.RemoveAt(idRemoveOrder);
            }

        }


        class Order
        {
            public Order(){}
            public void PrintInfo() { }
        }
        #endregion

        #region services
        public abstract class Service : IEditor
        {
            public string Name { get; set; }
            public int Price { get; set; }
            public Service(string name, int price)
            {
                Name = name;
                Price = price;
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
            public string Type { get; set; } 

            public Haircut(string type, int price) : base("Стрижка", price)
            {
                Type = type;
            }

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
            public string Type { get; set; } 

            public Coloring(string type, int price) : base("Фарбування", price)
            {
                Type = type;
            }

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
            public string Type { get; set; } 
            public string AdditionalServices { get; set; } 

            public Manicure(string type, int price, string additionalServices) : base("Манікюр", price)
            {
                Type = type;
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
            public string Type { get; set; } 
            public int Duration { get; set; } 

            public CosmeticProcedure(string type, int duration, int price) : base("Косметична процедура", price)
            {
                Type = type;
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
            public string Email { get; set; }
            public abstract void Edit();
            public abstract void PrintInfo();

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

        class Client : Person
        {
            public override void Edit() { }

            public override void PrintInfo()
            {
                Console.WriteLine($"Name: {Name}\t| Surname: {Surname}\t| Phonenumber: {PhoneNumber}\t| ");
            }
        }
        class Master : Person
        {
            public override void Edit() { }

            public override void PrintInfo()
            {
                Console.WriteLine($"Name: {Name}\t| Surname: {Surname}\t| Phonenumber: {PhoneNumber}\t| ");
            }
        }
        #endregion

        #region products
        public abstract class Product : IEditor
        {
            public string Name { get; set; }
            public int Price { get; set; }
            public abstract void Edit();
            public abstract void PrintInfo();
        }
        #endregion

    }
}