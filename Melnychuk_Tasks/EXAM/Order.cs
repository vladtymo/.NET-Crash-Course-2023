using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM
{
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

        public void Work()
        {
            Client.Money -= Service.Price * Performer.Rank;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Клієнт: {Client.Name} {Client.Surname} | Послуга: {Service.Name} | Дата: {Date.ToString("dd/MM/yyyy")} | Виконавець: {Performer.Name} {Performer.Surname}");
        }
    }
}
