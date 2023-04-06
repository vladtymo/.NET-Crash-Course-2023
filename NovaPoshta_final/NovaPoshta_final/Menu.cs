using NovaPoshta_final.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaPoshta_final
{
    internal class Menu
    {
        public void GoOverMainMenu()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
            MainMenu();
        }

        public void MainMenu()
        {
            Console.Clear();

            Console.WriteLine("Welcome to Nova Poshta!");
            Console.WriteLine("----- Main menu -----");
            Console.WriteLine("1. Send a parcel \n" +
                "2. Check for avaible parcels \n" +
                "3. Change phone number\n" +
                "4. Add new phone number\n" +
                "5. Check Your personal information\n" +
                "6. Check information as employee\n\n" +
                "Press any button to exit");

            int navigation = int.Parse(Console.ReadLine()!);

            switch (navigation)
            {
                case 1:
                    Console.Clear();
                    PostOperation client = new PostOperation();
                    client.SendParcel();
                    break;
                case 2:
                    Console.Clear();
                    client = new PostOperation();
                    client.GetParcel();
                    break;
                case 3:
                    Console.Clear();
                    client = new PostOperation();
                    client.ChangePhoneNumber();
                    break;
                case 4:
                    Console.Clear();    
                    client = new PostOperation();
                    client.CreateClient();
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("Enter surname to check");
                    string surname = Console.ReadLine()!;
                    Client client1 = new Client();
                    client1.ShowInfo(surname);
                    break;
                case 6:
                    Console.Clear();
                    DatabaseManager databaseManager = new DatabaseManager();
                    Console.WriteLine("Enter surname to check");
                    surname = Console.ReadLine()!;
                    Employee employee = databaseManager.GetEmployeeBySurname(surname);
                    if (employee == null)
                    {
                        Console.Clear();
                        Console.WriteLine("There is no employee with this surname");
                        MainMenu();
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        EmployeeMenu();
                    }
                    break;
                default:
                    break;
            }
        }

        public void EmployeeMenu()
        {
            Console.WriteLine("----- Employee menu -----");
            Console.WriteLine("1. Check clients information \n" +
                "2. Check for all parcels\n" +
                "3. Check for post offices\n" +
                "4. Check your own information \n\n" + 
                "Press any button to exit");

            int navigation = int.Parse(Console.ReadLine()!);

            switch (navigation)
            {
                case 1:
                    Console.Clear();
                    DatabaseManager databaseManager = new DatabaseManager();
                    IEnumerable<Client> clients = databaseManager.GetClients();

                    foreach (var client  in clients)
                    {
                        Console.WriteLine($"{client.Name} {client.Surname}| {client.PhoneNumber}");
                    }

                    Console.ReadKey();
                    Console.Clear();
                    EmployeeMenu();

                    break;
                case 2:
                    Console.Clear();
                    databaseManager = new DatabaseManager();
                    IEnumerable<Parcel> parcels = databaseManager.GetParcels();

                    foreach (var parcel in parcels)
                    {
                        Console.WriteLine($"{parcel.Name} {parcel.Weight}");
                    }

                    Console.ReadKey();
                    Console.Clear();
                    EmployeeMenu();
                    break;
                case 3:
                    Console.Clear();
                    databaseManager = new DatabaseManager();
                    IEnumerable<PostOffice> offices = databaseManager.GetOffices();

                    foreach (var office in offices)
                    {
                        Console.WriteLine($" Nova Poshta {office.Adress} N{office.PostNumber}");
                    }

                    Console.ReadKey();
                    Console.Clear();
                    EmployeeMenu();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Enter surname to check");
                    string surname = Console.ReadLine()!;
                    Employee employee = new Employee();
                    employee.ShowInfo(surname);
                    break;
               
                default:
                    MainMenu();
                    break;
            }
        }
    }
}
