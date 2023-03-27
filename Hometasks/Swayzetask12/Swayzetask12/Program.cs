using System;

namespace Program
{
    class task1
    {
        List<string> strings = new List<string>();

        public string maxvalue()
        {
            string maxval = "";
            strings.Add("Ajgfvnfn");
            strings.Add("Ajgfvnfn12123");
            strings.Add("Ajgfvnf2342n");
            strings.Add("Ajgfvnfn6566566565");
            strings.Add("Ajgfvnfn3343");
            strings.Add("Ajgfvnfn76782dsfdfgfdht");
            strings.Add("Ajgfvnfn787754");

            foreach (string s in strings)
            {
                if (s.Length > maxval.Length) maxval = s;
            }

            return maxval;
        }
    }

    class PhoneBook
    {
        private Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
        public void Add(string key, string number)
        {
            keyValuePairs.Add(key, number);
        }
        public void Change(string previouskey, string newkey)
        {
            foreach(KeyValuePair<string, string> pair in keyValuePairs)
            {
                if (pair.Key.Equals(previouskey))
                {
                    pair.Key.Replace(previouskey, newkey);
                }
            }
        }
        public void Change(string previouskey, string previousnumber, string newkey, string newnumber)
        {
            foreach (KeyValuePair<string, string> pair in keyValuePairs)
            {
                if (pair.Key.Equals(previouskey) && pair.Value.Equals(previousnumber))
                {
                    pair.Key.Replace(previouskey, newkey);
                    pair.Value.Replace(previousnumber, newnumber);
                }
            }
        }
        public void Change(string previousnumber, string newkey, string number)
        {
            foreach(KeyValuePair<string, string> pair in keyValuePairs)
            {
                if (pair.Value.Equals(previousnumber))
                {
                    pair.Value.Replace(previousnumber, number);
                    pair.Key.Replace(pair.Key, newkey);
                }
            }
        }

        public void Search(string key)
        {
            foreach(KeyValuePair<string,string> pair in keyValuePairs)
            {
                if (pair.Key.Equals(key) || pair.Value.Equals(key))
                {
                    Console.WriteLine($"[{pair.Key}] = [{pair.Value}]");
                }
            }
        }
        public void Search(string key, string number)
        {
            foreach (KeyValuePair<string, string> pair in keyValuePairs)
            {
                if (pair.Key.Equals(key) && pair.Value.Equals(number))
                {
                    Console.WriteLine($"[{pair.Key}] = [{pair.Value}]");
                }
            }
        }
        public void RemoveUser(string key)
        {
            if (keyValuePairs.ContainsKey(key))
            {
                keyValuePairs.Remove(key);
            }
        }
        public void Showinfo()
        {
            foreach(var key in keyValuePairs)
            {
                Console.WriteLine($"[{key.Key}] = [{key.Value}]");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            task1 task1 = new task1();
            Console.WriteLine(task1.maxvalue());

            PhoneBook phone = new PhoneBook();
            phone.Add("Ki", "+380659");
            phone.Showinfo();
            phone.Change("Ki", "KI");
            phone.Showinfo();
            //phone.Search
        }
    }
}