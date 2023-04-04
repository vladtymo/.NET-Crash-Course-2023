namespace task13part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PhoneBook phoneBook = new PhoneBook();

            bool continueRunning = true;

            while (continueRunning)
            {
                Console.WriteLine("Enter a command (add, update, delete, search, exit):");
                string command = Console.ReadLine();

                switch (command.ToLower())
                {
                    case "add":
                        Console.WriteLine("Enter name:");
                        string addName = Console.ReadLine();
                        Console.WriteLine("Enter phone number:");
                        string addPhoneNumber = Console.ReadLine();
                        phoneBook.AddEntry(addName, addPhoneNumber);
                        break;

                    case "update":
                        Console.WriteLine("Enter name:");
                        string updateName = Console.ReadLine();
                        Console.WriteLine("Enter phone number:");
                        string updatePhoneNumber = Console.ReadLine();
                        phoneBook.UpdateEntry(updateName, updatePhoneNumber);
                        break;

                    case "delete":
                        Console.WriteLine("Enter name:");
                        string deleteName = Console.ReadLine();
                        phoneBook.DeleteEntry(deleteName);
                        break;

                    case "search":
                        Console.WriteLine("Enter name:");
                        string searchName = Console.ReadLine();
                        phoneBook.SearchEntry(searchName);
                        break;

                    case "exit":
                        continueRunning = false;
                        break;

                    default:
                        Console.WriteLine("Invalid command");
                        break;
                }
            }
        }

        class PhoneBook
        {
            private Dictionary<string, string> _entries = new Dictionary<string, string>();

            public void AddEntry(string name, string phoneNumber)
            {
                if (_entries.ContainsKey(name))
                {
                    Console.WriteLine($"Entry for {name} already exists");
                }
                else
                {
                    _entries.Add(name, phoneNumber);
                    Console.WriteLine($"Entry added for {name}");
                }
            }

            public void UpdateEntry(string name, string phoneNumber)
            {
                if (_entries.ContainsKey(name))
                {
                    _entries[name] = phoneNumber;
                    Console.WriteLine($"Entry updated for {name}");
                }
                else
                {
                    Console.WriteLine($"Entry for {name} does not exist");
                }
            }

            public void DeleteEntry(string name)
            {
                if (_entries.ContainsKey(name))
                {
                    _entries.Remove(name);
                    Console.WriteLine($"Entry deleted for {name}");
                }
                else
                {
                    Console.WriteLine($"Entry for {name} does not exist");
                }
            }

            public void SearchEntry(string name)
            {
                if (_entries.ContainsKey(name))
                {
                    Console.WriteLine($"Phone number for {name}: {_entries[name]}");
                }
                else
                {
                    Console.WriteLine($"Entry for {name} does not exist");
                }
            }
        }
    }
}