using System.Collections;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _02_Task
{
    internal class Program:Dictionary<string, string>
    {
        class PhoneBook
        {
            private Dictionary<string, string> phoneBook = new();

            public void Add(string key, string number)
            {
                phoneBook.Add(key, number);
                Console.WriteLine($"This number({number}) has been added already");
            }
            public void Remove(string key)
            {
                phoneBook.Remove(key);
            }
            public void Change(string key, string value)
            {
                phoneBook[key] = value;
                Console.WriteLine($"This number({value}) has been changed already");

            }
            public void Search(string key)
            {
                if(phoneBook.ContainsKey(key))
                {
                    Console.WriteLine(phoneBook[key]);
                }
            }
            public void ShowBook() 
            {
                foreach (var item in phoneBook)
                {
                    Console.WriteLine($"{item.Key}:\t{item.Value}");
                }
            }
        }
        static void Main(string[] args)
        {
            PhoneBook phoneBook = new PhoneBook();
            phoneBook.Add("UA", "+380979279327");
            phoneBook.Add("USA", "+99823211800");
            phoneBook.Add("ENG", "+44456523254");
            phoneBook.Add("PL", "+962286552321");

            phoneBook.ShowBook();

            phoneBook.Remove("USA");
            Console.WriteLine();
            phoneBook.ShowBook();
            Console.WriteLine();
            phoneBook.Change("UA", "+380993254324");
            Console.WriteLine();
            phoneBook.Search("PL");
        }
    }
}
