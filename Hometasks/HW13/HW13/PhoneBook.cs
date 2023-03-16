using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW13
{
    internal class PhoneBook
    {
        public Dictionary<string, string> Book { get; set; }

        public PhoneBook(Dictionary<string, string> book)
        {
            Book = book;
        }
        public void Add(string name, string phone)
        {
            Book.Add(name, phone);
        }
        public void Update(string item, string newKey, string newValue)
        {
            if (Book.ContainsKey(item) || Book.ContainsValue(item))
                Book.Remove(item);
            Book.Add(newKey, newValue);
        }
        public void Search(string item)
        {
            foreach (var el in Book)
            {
                if (item == el.Key || item == el.Value)
                    Console.WriteLine($"{el.Key}:\t{el.Value}");
                else
                    Console.WriteLine("Not found...");
            }
        }
        public void Remove(string item)
        {
            Book.Remove(item);
        }
    }
}
