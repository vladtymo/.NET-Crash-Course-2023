using System;
using System.Collections.Generic;
class PhoneBook{
    private Dictionary<string, string> _entries;
    public PhoneBook(){
        _entries = new Dictionary<string, string>();
    }
    public void Add(string name, string phoneNumber){
        if (!_entries.TryAdd(name, phoneNumber)){
            Console.WriteLine($"'{name}' already exists");
        }
    }
    public void Change(string name, string newPhoneNumber){
        if (_entries.ContainsKey(name)){
            _entries[name] = newPhoneNumber;
        }
        else{
            Console.WriteLine($"No found '{name}'");
        }
    }
    public string Search(string name){
        if (_entries.TryGetValue(name, out string phoneNumber)){
            return phoneNumber;
        }
        else{
            Console.WriteLine($"No found '{name}'");
            return null;
        }
    }
    public void Delete(string name){
        if (!_entries.Remove(name)){
            Console.WriteLine($"No found '{name}'");
        }
    }
}
class Program{
    static void Main(string[] args){
        PhoneBook phoneBook = new PhoneBook();
        phoneBook.Add("Karina", "38095025774*");
        phoneBook.Add("Anton", "12345678907");
        Console.WriteLine($"Karina's phone number: {phoneBook.Search("Karina")}");
        phoneBook.Change("Karina", "0000000000");
        Console.WriteLine($"Karina's new phone number: {phoneBook.Search("Karina")}");
        phoneBook.Delete("Anton");
        phoneBook.Search("Anton");
    }
}
