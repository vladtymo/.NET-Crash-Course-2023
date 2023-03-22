namespace _13_GenericCollection
{
    internal class Program : Dictionary<string, string>
    {
        class PhoneBook
        {
            private Dictionary<string, string> phoneBook = new();
            public void Add(string name, string number)
            {
                phoneBook.Add(name, number);
                Console.WriteLine($"Number {name} has been added");
            }


            public void Remove(string name)
            {
                phoneBook.Remove(name);
                Console.WriteLine($"\nNumber {name} has been deleted");
            }
            public void Change(string name, string value)
            {
                phoneBook[name] = value;
                Console.WriteLine($"\nContact {name}  {value} has been changed");
            }
            public void Search(string name)
            {
                if (phoneBook.ContainsKey(name))
                {
                    Console.WriteLine($"\nFound contact {name}  {phoneBook[name]} ");
                }
            }
            public void ShowBook()
            {
                Console.WriteLine("\nPhoneBook:");
                foreach (var item in phoneBook)
                {
                    Console.WriteLine($"{item.Key} :\t{item.Value}");
                }
            }
        }

        static void Main(string[] args)
        {
            PhoneBook phoneBook = new PhoneBook();
            phoneBook.Add("Olena", "+380970887390");
            phoneBook.Add("Anna", "+380687296563");
            phoneBook.Add("Petro", "+380680010333");
            phoneBook.Add("Ivan", "+380989412382");
            phoneBook.ShowBook();
            phoneBook.Remove("Anna");
            phoneBook.ShowBook();        
            phoneBook.Change("Olena", "+380665850659");
            phoneBook.Search("Petro");


        }


    }


}