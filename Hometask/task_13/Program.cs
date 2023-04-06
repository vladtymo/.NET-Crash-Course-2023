namespace task_13
{
    internal class Program
    {

        static string ListMaxWordSearch(List<string> list)
        {
            int i = 0;
            foreach (string word in list)
            {
                if (word.Length > list[i].Length)
                    i = list.IndexOf(word);
                Console.Write(word + " ");
            }
            return list[i];
        }
        static void Main(string[] args)
        {
            List<string> list = new List<string> { "Artorias", "Babay", "Babay", "An-24", "ConsoleWriteline", "ConsoleWritelineAvias" };
            Console.WriteLine("\nWord: " + ListMaxWordSearch(list));
            Console.WriteLine();
            PhoneBook phoneBook = new PhoneBook();
            phoneBook.Add("Olesa", "380672715894");
            phoneBook.Add("Yura",  "380526478568");
            phoneBook.Add("Yura",  "380526478568");
            phoneBook.Add("Kolya", "380457964755");
            phoneBook.Add("Dima",  "380526478568");
            Console.WriteLine();
            phoneBook.Replacement("Yura", "38052666777");
            phoneBook.Replacement("Bom", "380569874236");
            Console.WriteLine();
            phoneBook.Remove("Yura", "38052666777");
            phoneBook.Remove("Yura", "38052666777");
            Console.WriteLine();
            phoneBook.Search("Yura");
            phoneBook.Search("Dima");






        }
    }
}