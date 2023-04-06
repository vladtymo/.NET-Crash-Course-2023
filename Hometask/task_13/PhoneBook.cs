
namespace task_13
{
    internal class PhoneBook
    {
        public Dictionary<string, string> phoneNumbers;

        public PhoneBook()
        {
            phoneNumbers = new Dictionary<string, string>();
        }

        public void Add(string name, string phoneNumber)
        {
            if (!phoneNumbers.TryGetValue(name, out phoneNumber))
            {
                phoneNumbers.Add(name, phoneNumber);
                Console.WriteLine("Add a new entry!!!");
            }
            else
                Console.WriteLine("This entry is present!!!");
        }

        public void Remove(string name, string phoneNumber) 
        {
            if (phoneNumbers.TryGetValue(name, out phoneNumber))
            {
                phoneNumbers.Remove(name);
                Console.WriteLine($"This entry:{name} has been removed!!!");
            }
            else
                Console.WriteLine("No record found!!!");
        }

        public void Replacement(string name, string phoneNumber)
        {
            if (phoneNumbers.TryGetValue(name, out phoneNumber))
            {
                phoneNumbers[name] = phoneNumber;
                Console.WriteLine($"This entry:{name} has been replacement!!!");
            }
            else
                Console.WriteLine("No record found!!!");

        }

        public void Search(string name)
        {
            if (phoneNumbers.ContainsKey(name))
                Console.WriteLine($"Name: {name} mobile number: {phoneNumbers[name]}");
            else
                Console.WriteLine("No record found!!!");
        }
    }
}
