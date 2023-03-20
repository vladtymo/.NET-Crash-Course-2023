using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crash_course_collections
{
    internal class PhoneBook
    {
        private Dictionary<string, string> phoneNumber = new Dictionary<string, string>();
        
        public PhoneBook( Dictionary<string, string> phoneNumber) 
        {
            this.phoneNumber = phoneNumber;
        }

        public void CreateNumber()
        {
            Console.WriteLine("Enter name and number!");
            Console.WriteLine("Name:");
            string name = Console.ReadLine()!;
            Console.WriteLine("Number:");
            string number = Console.ReadLine()!;

            phoneNumber[name] = number;
        }
        public void UpdateNumber()
        {
            Console.WriteLine("Enter name for updating number");
            string name = Console.ReadLine()!;

            foreach (var item in phoneNumber)
            {
                if (item.Key == name)
                {
                    Console.WriteLine("Enter number!");
                    string number = Console.ReadLine()!;
                    phoneNumber[name] = number;
                }
            }
        }
        public void FindNumber()
        {
            Console.WriteLine("Enter data to find number");
            string name = Console.ReadLine()!;

            foreach (var item in phoneNumber)
            {
                if (item.Key == name)
                {
                    Console.WriteLine($"{item.Key} --- {item.Value}");
                }
            }

        }
        public void RemoveNumber()
        {
            Console.WriteLine("Enter data to remove number");
            string name = Console.ReadLine()!;

            foreach (var item in phoneNumber)
            {
                if (item.Key == name)
                {
                    phoneNumber.Remove(item.Key);
                    Console.WriteLine("Item was removed!");
                }
            }
        }
    }
}
