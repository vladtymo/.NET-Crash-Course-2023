namespace Exam
{
    internal class Program
    {
        #region Task
        /*
         ------------------- Перукарня -------------------
            Створити ієрархію класів для подання інформації про  послуги перукарні
            	стрижка(вид, ціна)
            	Фарбування(вид, ціна)
            	Манікюр(вид, ціна, додаткові)
            	Косметична процедура( вид, тривалість, ціна)
            Створити програму для роботи перукарні
            	Вивід усіх послуг перукарні,  впорядковуючи за видом та назвою послуги
            	Додавання(вилучення, редагування)  послуги  у(з)  базу
            	Додавання(вилучення, редагування)   клієнта перукарні
            	Додавання(вилучення. редагування)   майстра(перукаря, косметолога у(з)  базу
            	Додавання(вилучення. редагування)  продуктів у(з)  базу
            	Можливість  попереднього замовлення послуги 
            	Реєстрація виконання послуги(клієнт, послуга, дата, виконавець)
        ----------------------------------------------------------------------------
         */
        #endregion
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
            void Add();
             void Remove();
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


        }


        class Order
        { }
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
            public abstract void Add();
            public abstract void Remove();
            public abstract void Edit();
          

            

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
            public override void Add() { }
            

            public override void Edit() { }


            public override void Remove() { }
            
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
            public override void Add() { }

            public override void Edit() { }

            public override void Remove() { }

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
            public override void Add() { }

            public override void Edit() { }

            public override void Remove() { }
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
            public override void Add() { }

            public override void Edit() { }

            public override void Remove() { }
        }
        #endregion

        #region persons
        public abstract class Person : IEditor
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public string PhoneNumber { get; set; }
            public string Email { get; set; }

            public abstract void Add();
            public abstract void Remove();
            public abstract void Edit();
            public abstract void ToString();

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
            public override void Add()
            {
                throw new NotImplementedException();
            }

            public override void Edit()
            {
                throw new NotImplementedException();
            }

            public override void Remove()
            {
                throw new NotImplementedException();
            }

            public override void ToString()
            {
                Console.WriteLine($"Name: {Name}\t| Surname: {Surname}\t| Phonenumber: {PhoneNumber}\t| ");
            }
        }
        class Master : Person
        {
            public override void Add()
            {
                throw new NotImplementedException();
            }

            public override void Edit()
            {
                throw new NotImplementedException();
            }

            public override void Remove()
            {
                throw new NotImplementedException();
            }

            public override void ToString()
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
            public abstract void Add();
            public abstract void Remove();
            public abstract void Edit();
        }
        #endregion




        static void Main(string[] args)
        {
            Client client = new Client();

            Master master = new Master();   

           
        }
    }
}