using EXAM;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Exam.Program;

namespace EXAM
{
    public class BeautySalon
    {

        public string Name { get; set; } = "Victoria";

        public List<Person> Persons { get; set; } = new List<Person>();

        public List<Product> Products { get; set; } = new List<Product>();

        public List<Service> Services { get; set; } = new List<Service>();

        public List<Order> Orders { get; set; } = new List<Order>();

        public static void ShowItems<T>(List<T> items, Action<T> printMethod)
        {
           Console.WriteLine($"\n\t\tСписок елементів типу {typeof(T).Name}:");
            
            if (items.Count != 0)
            {
                int i = 1;
                foreach (T item in items)
                {
                    Console.Write($"\t\t№{i}\t|");
                    printMethod(item);
                    i++;
                }
            }
            else Console.WriteLine("\n\t\t\tСписок пустий.");

            Console.WriteLine();
           
        }


        public void ShowPerson() { ShowItems(Persons, p => p.PrintInfo()); }
        public void AddPerson()
        {
            Console.Clear();
            ShowPerson();
            Console.WriteLine("\n\t\tВиберіть кого ви хочете додати ");
            Console.Write("\n\t\tЯкщо хочете додати Майстра введіть 1/Клієнта 2: ");
            int b = int.Parse(Console.ReadLine());
            if (b == 1)
            {
                Console.Write("\n\t\tВведіть ранг(1-5): ");
                int rank = int.Parse(Console.ReadLine());
                Master master = new Master(rank);
                Persons.Add(master);
            }
            else if (b == 2)
            {
                Console.Write("\n\t\tВведіть кількість грошей: ");
                int money = int.Parse(Console.ReadLine());
                Client client = new Client(money);
                Persons.Add(client);
            }
            Console.Clear();

            Console.Write("\n\t\tЯкщо хочете продовжити додавання введіть +(якщо ні то будь що): ");
            bool Check = (Console.ReadLine()) == "+" ? true : false;
            if (Check)
            {
                AddPerson();
            }

        }
        public void RemovePerson()
        {
            ShowPerson();
            Console.WriteLine("\n\t\tВиберіть кого ви хочете видалити");
            Console.Write($"\n\t\tВведіть номер: ");
            int idRemovePerson = int.Parse(Console.ReadLine()) - 1;
            Persons.RemoveAt(idRemovePerson);
            Console.Clear();
        }

        public void ShowProduct() { ShowItems(Products, p => p.PrintInfo()); }
        public void AddProduct()
        {
            Console.Clear();

            ShowProduct();
            Console.Write("\n\t\tВведіть нове ім'я: ");
            string name = Console.ReadLine();
            Console.Write("\n\t\tВведіть нову варітсть: ");
            int price = int.Parse(Console.ReadLine());
            Product product = new Product(name, price);
            Products.Add(product);
            Console.Clear();

            Console.Write("\n\t\tЯкщо хочете продовжити додавання введіть +(якщо ні то будь що): ");
            bool Check = (Console.ReadLine()) == "+" ? true : false;
            if (Check)
            {
                AddProduct();
            }
        }
        public void RemoveProduct()
        {
            ShowProduct();
            Console.WriteLine("\n\t\tВиберіть що ви хочете видалити");
            Console.Write($"\n\t\tВведіть номер: ");
            int idRemoveProduct = int.Parse(Console.ReadLine()) - 1;
            Products.RemoveAt(idRemoveProduct);
            Console.Clear();
        }

        public void ShowService() { ShowItems(Services, p => p.PrintInfo()); }
        public void AddService()
        {
            Console.Clear();
            ShowService();
            Console.WriteLine("\n\t\tВиберіть що ви хочете додати: ");

            Console.Write("\n\t\tЯкщо хочете додати: \n\t\tHaircut - 1 \n\t\tColoring - 2 \n\t\tManicure - 3 \n\t\tCosmeticProcedure - 4 \n\t\tВаш вибір: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("\n\t\tВведіть прайс: ");
            int price = int.Parse(Console.ReadLine());
            Console.Write("\n\t\tВведіть тип: ");
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
                    Console.Write("\n\t\tВведіть додаткові побажання: ");
                    string additionalServices = Console.ReadLine();
                    Manicure manicure = new Manicure(type, price, additionalServices);
                    Services.Add(manicure);
                    break;
                case 4:
                    Console.Write("\n\t\tВведіть тривалість: ");
                    int duration = int.Parse(Console.ReadLine());
                    CosmeticProcedure cosmeticProcedure = new CosmeticProcedure(type, price, duration);
                    Services.Add(cosmeticProcedure);
                    break;
                default: break;
            }
            Console.Clear();

            Console.Write("\n\t\tЯкщо хочете продовжити додавання введіть +(якщо ні то будь що): ");
            bool Check = (Console.ReadLine()) == "+" ? true : false;
            if (Check)
            {
                AddService();
            }
        }
        public void RemoveService()
        {
            ShowService();
            Console.WriteLine("\n\t\tВиберіть що ви хочете видалити");
            Console.Write($"\n\t\tВведіть номер: ");
            int idRemoveService = int.Parse(Console.ReadLine()) - 1;
            Services.RemoveAt(idRemoveService);
            Console.Clear();
        }

        public void ShowOrder() { ShowItems(Orders, p => p.PrintInfo()); }
        public void AddOrder()
        {
            Console.Clear();
            ShowOrder();
            Console.Write("\n\t\tВиберіть Client в списку усіх персон(його номер)");
            ShowPerson();
            Console.Write("\n\t\tВаш вибір: ");
            int c = int.Parse(Console.ReadLine()) - 1;
            Client client = (Client)Persons[c];
            
            Console.Write("\n\t\tВиберіть послугу в списку усіх послуг(її номер)");
            ShowService();
            Console.Write("\n\t\tВаш вибір: ");
            int s = int.Parse(Console.ReadLine()) - 1;
            Service service = Services[s];
            
            Console.Write("\n\t\tВведіть дату (format: dd/MM/yyyy): ");
            string input = Console.ReadLine();
            DateTime date = DateTime.ParseExact(input, "dd/MM/yyyy", CultureInfo.InvariantCulture);
          
            Console.Write("\n\t\tВиберіть Master в списку усіх персон(його номер): ");
            ShowPerson();
            Console.Write("\n\t\tВаш вибір: ");
            int p = int.Parse(Console.ReadLine()) - 1;
          
            Master master = (Master)Persons[p];

            Order order = new Order(client, service, date, master);
            Orders.Add(order);
            Console.Clear();

            Console.Write("\n\t\tЯкщо хочете продовжити додавання введіть +(якщо ні то будь що): ");
            bool Check = (Console.ReadLine()) == "+" ? true : false;
            if (Check)
            {
                AddOrder();
            }
        }
        public void RemoveOrder()
        {
            ShowOrder();
            Console.WriteLine("\n\t\tВиберіть що ви хочете видалити");
            Console.Write($"\n\t\tВведіть номер: ");
            int idRemoveOrder = int.Parse(Console.ReadLine()) - 1;
            Orders.RemoveAt(idRemoveOrder);
            Console.Clear();
        }

    }
}
