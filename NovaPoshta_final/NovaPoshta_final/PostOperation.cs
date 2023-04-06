using NovaPoshta_final.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaPoshta_final
{
    internal class PostOperation
    {
        public void SendParcel()
        {
            Random random = new Random();
            DatabaseManager databaseManager = new DatabaseManager();

            Console.WriteLine("Choose ardress for delivering (City/ Region/ Adress)");
            string adress = Console.ReadLine()!;

            Console.WriteLine("Calculating weight...");
            int weight = random.Next(1, 20);

            Console.WriteLine("Enter your phone number");
            string cliPhoneNum = Console.ReadLine()!;
            Client client = databaseManager.GetClientByPhoneNumber(cliPhoneNum);
            if (client != null)
            {
                Console.WriteLine($"Client: {client.Name} {client.Surname}|{client.PhoneNumber}");
            }
            else
            {
                Console.WriteLine("---Invalid phone number---");
                return;
            }

            Console.WriteLine("Enter post number");
            int postNum = int.Parse(Console.ReadLine()!);
            PostOffice arrivedOffice = databaseManager.GetPostOfficeByNumber(postNum);
            if (arrivedOffice == null)
            {
                Console.WriteLine("---Invalid post number---");
                return;
            }

            Console.WriteLine("Enter phone number of addresseee");
            string adrPhoneNum = Console.ReadLine()!;
            Client addressee = databaseManager.GetClientByPhoneNumber(adrPhoneNum);
            if (addressee != null)
            {
                Console.WriteLine($"Addressee: {addressee.Name} {addressee.Surname}|{addressee.PhoneNumber}");
            }
            else
            {
                Console.WriteLine("---Invalid phone number---");
                return;
            }
            Console.WriteLine("What a parcel?");
            string name = Console.ReadLine()!;

            Parcel parcel = new() { Name = name, Weight = weight, IsArrived = false, PostOfficeId = arrivedOffice.Id, ClientId = client.Id, AddresseeId = addressee.Id };
            databaseManager.AddParcel(parcel);

            int payment = 50 + weight * 3;
            Console.WriteLine($"Your parcel will arrive {DateOnly.FromDateTime(DateTime.Now)}. Sum of deliver is {payment}");

            GetBell(addressee, client, parcel);

            Console.WriteLine("Do you want bell?");
            Console.WriteLine("1 -- yes\n" +
                "2 -- no");

            int caseInt = int.Parse(Console.ReadLine()!);

            switch (caseInt)
            {
                case 1:
                    PrintBell();
                    break;
                case 2:
                    break;
                default:
                    break;
            }

            Menu menu = new Menu();
            menu.GoOverMainMenu();
        }

        public void GetParcel()
        {
            PostOffice postOffice = new PostOffice();
            DatabaseManager databaseManager = new DatabaseManager();
            int current_balance = 0;

            Employee employee = databaseManager.GetRandomEmployee();

            Console.WriteLine("Enter your phone number");
            string phonenUmber = Console.ReadLine()!;
            Client client = databaseManager.GetClientByPhoneNumber(phonenUmber);
            if (client != null)
            {
                Console.WriteLine($"Client: {client.Name} {client.Surname}|{client.PhoneNumber}");
            }
            else
            {
                Console.WriteLine("---Invalid phone number---");
                return;
            }

            var parcels = databaseManager.GetParcels(client.Id);

            Console.WriteLine("Your avaible parcels:");
            foreach (var parcel in parcels)
            {
                Console.WriteLine($"{parcel.Name}| {parcel.Weight}");
                Console.WriteLine(new string('-', 15));
                current_balance += 50 + (parcel.Weight * 3);
            }

            foreach (var parcel in parcels)
            {
                GetBell(client, parcel);

                Console.WriteLine("Do you want bell?");
                Console.WriteLine("1 -- yes\n" +
                    "2 -- no");

                int caseInt = int.Parse(Console.ReadLine()!);

                switch (caseInt)
                {
                    case 1:
                        PrintBell();
                        break;
                    case 2:
                        break;
                    default:
                        break;
                }
            }

            databaseManager.RemoveParcels(parcels);
            Console.WriteLine($"Price for all parcels {current_balance}");

            Menu menu = new Menu();
            menu.GoOverMainMenu();
        }

        public void CreateClient()
        {
            DatabaseManager databaseManager = new DatabaseManager();
            Console.WriteLine("Enter your name");
            string clientName = Console.ReadLine()!;
            Console.WriteLine("Enter your surname");
            string clientSurname = Console.ReadLine()!;
            Console.WriteLine("Enter your age");
            int age = int.Parse(Console.ReadLine()!);

            if (age < 6 || age > 122)
            {
                Console.Clear();
                Console.WriteLine("Invalid data!");
                CreateClient();
            }

            Console.WriteLine("Enter your phone number");
            string phoneNumber = Console.ReadLine()!;

            Client client = new() { Name = clientName, Surname = clientSurname, Age = age, PhoneNumber = phoneNumber, ParticipantRole = Role.Сlient };
            databaseManager.InsertClient(client);

            Menu menu = new Menu();
            menu.GoOverMainMenu();
        }

        public void ChangePhoneNumber()
        {
            Console.WriteLine("New number");
            string newNumber = Console.ReadLine()!;
            Console.WriteLine("Client id:");
            int id = int.Parse(Console.ReadLine()!);
            DatabaseManager databaseManager = new DatabaseManager();

            try
            {
                databaseManager.UpdatePhoneNumberById(id, newNumber);
            }
            catch (Exception exeption)
            {
                Console.WriteLine("Unknown id!");
            }

            Menu menu = new Menu();
            menu.GoOverMainMenu();
        }

        public void GetBell(Client addressee, Client client, Parcel parcel)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(new string('-', 25));
            stringBuilder.AppendLine($"Name receiver: {addressee.Name} {addressee.Surname} - {addressee.PhoneNumber}");
            stringBuilder.AppendLine($"Name client: {client.Name} {client.Surname} - {client.PhoneNumber}");
            stringBuilder.AppendLine(new string('-', 25));
            stringBuilder.AppendLine($"{parcel.Name} - price {50 + parcel.Weight * 3}");
            stringBuilder.AppendLine(new string('-', 25));

            File.WriteAllText("Bell.txt", stringBuilder.ToString());
        }

        public void GetBell(Client client, Parcel parcel)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(new string('-', 25));
            stringBuilder.AppendLine($"Name client: {client.Name} {client.Surname} - {client.PhoneNumber}");
            stringBuilder.AppendLine(new string('-', 25));
            stringBuilder.AppendLine($"{parcel.Name} - price {50 + parcel.Weight * 3}");
            stringBuilder.AppendLine(new string('-', 25));

            File.WriteAllText("Bell.txt", stringBuilder.ToString());
        }

        public void PrintBell()
        {
            string fileText = File.ReadAllText("Bell.txt");
            Console.WriteLine(fileText);
        }
    }
}
