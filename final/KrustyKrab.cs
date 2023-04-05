using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.IO;

[Serializable]
public class KrustyKrab : IEnumerable<Item>{
    public List<Item> Menu = new List<Item>();
    public List<Employee> Employees = new List<Employee>();

    public KrustyKrab(){
        // Menu.Add(new KrabsBurger(BurgerType.Basic));
        // Menu.Add(new KrabsBurger(BurgerType.Double));
        // Menu.Add(new KrabsBurger(BurgerType.Tribble));
        // Menu.Add(new Soda(SodaVolume.Volume0_33));
        // Menu.Add(new Soda(SodaVolume.Volume0_5));
        // Menu.Add(new Soda(SodaVolume.Volume1));
        // Menu.Add(new Soda(SodaVolume.Volume1_5));
        // Menu.Add(new KelpRings(true));
        // Menu.Add(new KelpRings(false));
        // Menu.Add(new KelpShake());

    }
    public void ShowMenu(){
        var sb = new StringBuilder();
        sb.AppendLine("########################")
        .AppendLine("##  Krusty Krab Menu  ##")
        .Append("########################");
        Console.WriteLine(sb);
        foreach (var item in Menu)
        {
            System.Console.WriteLine(item);
        }
    }
    public void ShowEmployees(){
        var sb = new StringBuilder();
        sb.AppendLine("#######################")
        .AppendLine("##   Our Employees   ##") 
        .AppendLine("#######################");
        
        foreach (var employee in Employees)
        {
            sb.AppendLine(employee.ToString());
        }
        Console.WriteLine(sb);
    }
    public void AddItem(Item item){
        Menu.Add(item);
        SaveMenu();
    }
    public void RemoveItem(){
        int i = 1;
        foreach (var item in Menu)
        {
            Console.Write($"[{i}] ");
            Console.WriteLine(item);
            ++i;
        }
        Console.WriteLine("Select item to remove: ");
        int itemIndex = int.Parse(Console.ReadLine());
        Menu.Remove(Menu[itemIndex-1]);
        SaveMenu();
    }
    public void AddEmployee(Employee employee){
        Employees.Add(employee);
    }
    public void Order(){
        Order order = new Order();
        Options option;
        bool ordering = true;
        while(ordering){
            Console.WriteLine("Please choose an option:");
            foreach (Options o in Enum.GetValues(typeof(Options)))
            {
                Console.WriteLine($"[{(int)o}] {o}");
            }
            option = Enum.Parse<Options>(Console.ReadLine());

            switch (option)
            {
                case Options.AddItem:
                    Console.WriteLine("Add item selected");
                    int i = 1;
                    foreach (var item in Menu)
                    {
                        Console.Write($"[{i}] ");
                        Console.WriteLine(item);
                        ++i;
                    }
                    Console.WriteLine("Select item: ");
                    int menuChoice = int.Parse(Console.ReadLine());
                    Console.WriteLine("Select count of item: ");
                    int countItem = int.Parse(Console.ReadLine());
                    order.AddItem(Menu[menuChoice-1],countItem);
                    break;
                case Options.RemoveItem:
                    Console.WriteLine("Remove item selected");
                    order.RemoveItem();
                    break;
                case Options.ShowOrder:
                    Console.WriteLine("Show order selected");
                    order.ShowOrder();
                    break;
                case Options.ShowTotalPrice:
                    Console.WriteLine("ShowTotalPrice selected");
                    order.Total();
                    break;
                case Options.CreateOrder:
                    Console.WriteLine("Create order selected");
                    order.CreateOrder();
                    ordering = false;
                    break;
                case Options.Exit:
                    Console.WriteLine("Exit");
                    ordering = false;
                    break;
            }
        }
    }
    public void SaveMenu(){
        var options = new JsonSerializerOptions
        {
            Converters = { new UniversityJsonConverter() },
            WriteIndented = true
        };
        string jsonToSave = JsonSerializer.Serialize<object>(Menu, options);
        File.WriteAllText("data.json", jsonToSave);
    }
    public void SaveEmployees(){
        var options = new JsonSerializerOptions
        {
            WriteIndented = true
        };
        string jsonToSave = JsonSerializer.Serialize<object>(Employees,options);
        File.WriteAllText("Employees.json", jsonToSave);
    }
    public void LoadMenu(){
        string json = File.ReadAllText("data.json");
        var options = new JsonSerializerOptions
        {
            Converters = { new UniversityJsonConverter() },
            WriteIndented = true
        };
        List<Item> items = JsonSerializer.Deserialize<List<Item>>(json,options);
        Menu.AddRange(items);
    }
    public void LoadEmployees(){
        string json = File.ReadAllText("Employees.json");
        var options = new JsonSerializerOptions
        {
            WriteIndented = true
        };
        List<Employee> employees = JsonSerializer.Deserialize<List<Employee>>(json,options);
        Employees.AddRange(employees);
    }
    public void Sort(IComparer<Item> comparer)
    {
        Menu.Sort(comparer);
    }
    public IEnumerator<Item> GetEnumerator()
    {
        return ((IEnumerable<Item>)Menu).GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

}
