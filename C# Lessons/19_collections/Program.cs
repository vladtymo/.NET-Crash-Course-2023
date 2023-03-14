using System.Collections.Generic;

namespace _19_collections
{
    internal class Program
    {
        static void Show<T>(IEnumerable<T> collection, string title = "")
        {
            Console.Write(title + ": ");
            foreach (var item in collection)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            #region List collection
            List<int> list = new() { 1, 4, 6, 9 };

            list.Add(34);
            list.Add(55);
            list.Add(122);
            list.Add(9);
            list.Add(9);

            list[3] = 777;
            Console.WriteLine("Element at 3 index: " + list[3]);

            list.TrimExcess(); // trim capacity to actual length

            Show(list, "Original array");

            Console.WriteLine($"Count: {list.Count}");
            Console.WriteLine($"Capacity: {list.Capacity}");

            list.Remove(6);

            if (!list.Contains(6))
                Console.WriteLine("List does not contain the value of 6!");

            list.RemoveAt(list.Count - 1);
            list.Reverse();

            Show(list, "Modified array");

            list.Clear();
            #endregion

            #region Stack / Queue collection
            // LIFO - Last In - First Out
            Stack<string> stack = new();

            stack.Push("Nazar");
            stack.Push("Vlad");
            stack.Push("Mykola");

            Console.WriteLine("Last item: " + stack.Peek());

            while (stack.Count > 0)
            {
                Console.WriteLine("Next: " + stack.Pop());
            }

            // FIFO - First In - First Out
            Queue<string> queue = new();

            queue.Enqueue("Nazar");
            queue.Enqueue("Vlad");
            queue.Enqueue("Mykola");

            Console.WriteLine("Last item: " + queue.Peek());

            while (queue.Count > 0)
            {
                Console.WriteLine("Next: " + queue.Dequeue());
            }
            #endregion

            Dictionary<string, string> dictionary = new()
            {
                ["UA"] = "Ukraine",
                ["PL"] = "Poland",
                ["USA"] = "United States of America",
                ["UK"] = "United Kindom"
            };

            dictionary["USA"] = "Capitan America";

            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key}:\t{item.Value}");
            }

            Console.WriteLine("UA code defines country of " + dictionary["UA"]);

            if (dictionary.ContainsKey("PL"))
                Console.WriteLine("Contains PL code!");

            if (dictionary.ContainsValue("Italy"))
                Console.WriteLine("Contains Italy country!");

            foreach (var key in dictionary.Keys) Console.WriteLine(key); Console.WriteLine();
            foreach (var value in dictionary.Values) Console.WriteLine(value); Console.WriteLine();

            // add new item
            dictionary.Add("RU", "Russia");
            dictionary.Remove("RU");

            dictionary["DE"] = "Germany";

            Console.WriteLine("Count: " + dictionary.Count);
        }
    }
}