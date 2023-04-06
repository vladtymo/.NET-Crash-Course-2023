using Microsoft.EntityFrameworkCore;
using NovaPoshta_final.Databasae;
using NovaPoshta_final.Entities;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NovaPoshta_final
{
    internal class DatabaseManager
    {
        private ApplicationDbContext context = new ApplicationDbContext();

        public void UpdatePhoneNumberById(int id, string phoneNum)
        {
            var client = new Client { Id = id, PhoneNumber = phoneNum };

            using (context = new ApplicationDbContext())
            {
                context.Clients.Attach(client);
                context.Entry(client).Property(c => c.PhoneNumber).IsModified = true;
                context.SaveChanges();
            }
        }

        public Client? GetClientByPhoneNumber(string number)
        {
            return context.Clients
                .Where(x => (x.PhoneNumber == number))
                .FirstOrDefault();
        }

        public Client GetClient(int id)
        {
            return context.Clients.Find(id);
        }

        public Employee GetEmployee(int id)
        {
            return context.Employees.Find(id);
        }

        public PostOffice GetPostOfficeByNumber(int postNum)
        {
            return context.Offices
                .Where(x => (x.PostNumber == postNum))
                .FirstOrDefault();
        }

        public async void AddParcel(Parcel parcel)
        {
            await context.Parcels.AddAsync(parcel);
            await context.SaveChangesAsync();
        }

        public ICollection<Parcel> GetParcels(int id)
        {
            var parcels = context.Parcels.Where(x => x.AddresseeId == id).ToList();
            return parcels;
        }

        public void RemoveParcels(ICollection<Parcel> parcels)
        {
            foreach (var parcel in parcels)
            {
                context.Parcels.Remove(parcel);
                context.SaveChanges();
            }
        }

        public Employee GetRandomEmployee()
        {
            Random rand = new Random();
            int randId = rand.Next(0, context.Employees.Count());

            return context.Employees.Find(randId);
        }

        public Client? GetClientBySurname(string surname)
        {
            return context.Clients
                .Where(x => (x.Surname == surname))
                .FirstOrDefault();
        }

        public Employee? GetEmployeeBySurname(string surname)
        {
            return context.Employees
                .Where(x => (x.Surname == surname))
                .FirstOrDefault();
        }

        public void InsertClient(Client client)
        {
            context.Clients.Add(client);
            context.SaveChanges();
        }

        public ICollection<Client> GetClients()
        {
            return context.Clients.ToList();
        }

        public ICollection<Parcel> GetParcels()
        {
            return context.Parcels.ToList();
        }

        public ICollection<PostOffice> GetOffices()
        {
            return context.Offices.ToList();
        }
    }
}
