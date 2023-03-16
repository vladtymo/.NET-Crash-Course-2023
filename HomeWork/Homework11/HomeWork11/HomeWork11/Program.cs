using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Numerics;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HomeWork11
{

    class Phonebook
    {
        Dictionary<string, string> dictionary = new();
        public void Add(string name,string phone)
        {
            dictionary.Add(name, phone);
        }
        public void Edit(string name,string phone)
        {
            dictionary[name] = phone;
        }
        public void Delete(string name)
        {
            dictionary.Remove(name);
        }
        public void Show()
        {
            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key}:\t{item.Value}");
            }
        }
        public void Search(string name)
        {
            foreach (var item in dictionary)
            {
                if (item.Key==name)
                { 
                Console.WriteLine($"Finded contacts: {item.Key}:\t{item.Value}");
                    break;
                }
            }
        }


    }



    class Cards
    {

        Queue<string> queue = new();


        public void Push(string card)
        {
            queue.Enqueue(card);
            Console.WriteLine("Pushed card: " + card);
        }
        public void Recieve()
        {
            Console.WriteLine("My Last item: " + queue.Peek());
        }


        public void Take6Count()
        {

            if (queue.Count>0)
            for (int i = 0; i <=5; i++)
            {
                    Console.WriteLine($"\tTake card {i}st with name : " + queue.Dequeue());

            }
        }
        public void ShuffleTheCards()
        {
            string[] array = queue.ToArray();
            Random random = new Random();
            
            for (int i = 0; i < array.Length; i++)
            {
                int j = random.Next(i, array.Length);
                //Fisher–Yates shuffle Algorithm
                string temp = array[i];
                //вносимо в елемент i рандомний елемент зі списку
                array[i] = array[j];
                //вносимо в рандомний елемент зі списку елемент i
                array[j] = temp;
            }
            queue.Clear();
            foreach (string num in array)
            {
                queue.Enqueue(num);
            }
            Console.Write("\nSorted randomly queue\n");

            foreach (string num in queue)
            {
                Console.Write("\t\t\t"+num + "\n");
            }
        }


    }




    class Hanoya
    {
        Stack<string> tower1 = new();
        Stack<string> tower2 = new();
        Stack<string> tower3 = new();

        public void Show()
        {
            Console.WriteLine("tower1:\n");
            foreach (string item in tower1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("tower2:\n");
            foreach (string item in tower2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("tower3:\n");
            foreach (string item in tower3)
            {
                Console.WriteLine(item);
            }
        }


        public void Addto1Tower(int size)
        {
            tower1.Push($"{size}");
        }
        public void From1to2Tower()
        {
            var element=tower1.Pop();
            tower2.Push(element);
        }
        public void From1to3Tower()
        {
            var element = tower1.Pop();
            tower3.Push(element);
        }
        public void From3to1Tower()
        {
            var element = tower3.Pop();
            tower1.Push(element);
        }
        public void From3to2Tower()
        {
            var element = tower3.Pop();
            tower2.Push(element);
        }
        public void From2to1Tower()
        {
            var element = tower2.Pop();
            tower1.Push(element);
        }
        public void From2to3Tower()
        {
            var element = tower2.Pop();
            tower3.Push(element);
        }


    }
    internal class Program
    {
        static int GetLength(string str)
        {
            return str.Length;
        }
        static char GetFirstChar(string str)
        {
            return str[0];
        }



        static void Main(string[] args)
        {

            //Знайти в колекції типу List<string> максимальне по довжині слово, якщо таких
            //виявляється кілька, виводимо на екран те, яке стоїть раніше в словнику(алфавіті)
            List<string> list = new() { "Work", "Fly", "Window", "Minimum", "Maximum", "Hero","Aladin","Strateg"};
            string maxLengthWord = list.OrderByDescending(GetLength).ThenBy(GetFirstChar).First(); 
            Console.WriteLine("Word with maximum characters and alphavit filter: " + maxLengthWord);

            //Реалізувати клас PhoneBook на базі дженерік колекції Dictionary<TKey, TValue>,
            //передбачити додавання, зміну, пошук та видалення записів
            Phonebook phonebook = new Phonebook();
            
            phonebook.Add("Andrey", "380932345234");
            phonebook.Add("Sasha", "380932142736");
            Console.WriteLine("Show Added contacts:");
            phonebook.Show();
            Console.WriteLine("\n");

            phonebook.Search("Andrey");

            Console.WriteLine("\n");
            phonebook.Edit("Andrey", "380936433231");
            Console.WriteLine("Show Edited contacts:");
            phonebook.Show();
            Console.WriteLine("\n");

            phonebook.Delete("Andrey");
            Console.WriteLine("Show after deleted contacts:");
            phonebook.Show();
            Console.WriteLine("\n");



            Cards cards = new Cards();
            cards.Push("Ace");
            cards.Push("Jack");
            cards.Push("Queen");
            cards.Push("King");
            cards.Push("Joker");
            cards.Push("2");
            cards.Push("3");
            cards.Push("4");
            cards.Push("5");
            cards.Push("6");
            cards.Push("7");
            cards.Push("8");
            cards.Push("9");
            cards.Push("10");


            
            cards.ShuffleTheCards();
            cards.Take6Count();
            cards.Recieve();

            Hanoya hanoya = new Hanoya();


            int number = 7;
            for (int i = 1; i < number + 1; i++)
            {
                hanoya.Addto1Tower(i);
            }

            hanoya.Show();

            if (number==7)
            { 
                hanoya.From1to3Tower();
                hanoya.From1to2Tower();
                hanoya.From2to3Tower();

                hanoya.From1to3Tower();

                hanoya.From1to3Tower();
            hanoya.From1to2Tower();
            hanoya.From2to3Tower();

                hanoya.From1to3Tower();
                hanoya.From1to2Tower();
                hanoya.From2to3Tower();
            }
            if (number==6)
            { 
                hanoya.From1to3Tower();
                hanoya.From1to2Tower();
                hanoya.From2to3Tower();

                hanoya.From1to3Tower();
                hanoya.From1to2Tower();
                hanoya.From2to3Tower();

                hanoya.From1to3Tower();
                hanoya.From1to2Tower();
                hanoya.From2to3Tower();
            }




            hanoya.Show();


        }
    }
}