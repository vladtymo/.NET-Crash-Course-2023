using System;
using System.Collections.Generic;
using System.Linq;

public abstract class Property{
    public int Id { get; set; }
    public string District { get; set; }
    public double Area { get; set; }
    public int Rooms { get; set; }
    public int Floor { get; set; }
    public double Price { get; set; }
    public string Address { get; set; }
    public abstract string GetDescription();
}

public class Apartment : Property{
    public override string GetDescription(){
        return $"Адреса: {Address}, район: {District}, площа: {Area} кв.м, кімнат: {Rooms}, поверх: {Floor}, ціна: {Price} грн.";
    }
}

public class ClientRequest{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string RequestType { get; set; } // обмін, купівля або продаж
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    public DateTime RequestDate { get; set; }
}

// Інтерфейс для сервісів роботи з нерухомістю
public interface IPropertyService{
    void AddProperty(Property property);
    void RemoveProperty(int propertyId);
    IEnumerable<Property> GetAllProperties();
    IEnumerable<Property> GetFilteredProperties(Func<Property, bool> filter);
    void UpdateProperty(int propertyId, Property newProperty);
}

// Інтерфейс для сервісів роботи з клієнтами
public interface IClientService{
    void AddClientRequest(ClientRequest request);
    void RemoveClientRequest(int requestId);
    IEnumerable<ClientRequest> GetAllClientRequests();
    ClientRequest GetClientBySurname(string surname);
    ClientRequest GetClientByPhoneNumber(string phoneNumber);
}

// Реалізація сервісу нерухомості
public class PropertyService : IPropertyService{
    private List<Property> _properties = new List<Property>();
    public void AddProperty(Property property){
        _properties.Add(property);
    }
    public void RemoveProperty(int propertyId){
        _properties.RemoveAll(p => p.Id == propertyId);
    }
    public IEnumerable<Property> GetAllProperties(){
        return _properties;
    }
    public IEnumerable<Property> GetFilteredProperties(Func<Property, bool> filter){
        return _properties.Where(filter);
    }
    public void UpdateProperty(int propertyId, Property newProperty){
        var property = _properties.FirstOrDefault(p => p.Id == propertyId);
        if (property != null){
            property.District = newProperty.District;
            property.Area = newProperty.Area;
            property.Rooms = newProperty.Rooms;
            property.Floor = newProperty.Floor;
            property.Price = newProperty.Price;
            property.Address = newProperty.Address;
        }
    }
}

// Реалізація сервісу клієнтів
public class ClientService : IClientService{
    private List<ClientRequest> _clientRequests = new List<ClientRequest>();
    public void AddClientRequest(ClientRequest request){
        _clientRequests.Add(request);
    }
    public void RemoveClientRequest(int requestId){
        _clientRequests.RemoveAll(r => r.Id == requestId);
    }
    public IEnumerable<ClientRequest> GetAllClientRequests(){
        return _clientRequests;
    }
    public ClientRequest GetClientBySurname(string surname){
        return _clientRequests.FirstOrDefault(r => r.FullName.Contains(surname));
    }
    public ClientRequest GetClientByPhoneNumber(string phoneNumber){
        return _clientRequests.FirstOrDefault(r => r.PhoneNumber == phoneNumber);
    }

}

// Основний клас програми
public class Program{
    public static void Main(){
        IPropertyService propertyService = new PropertyService();
        IClientService clientService = new ClientService();

        // Заповнення бази даних прикладами нерухомості та заявок клієнтів
        propertyService.AddProperty(new Apartment { Id = 1, District = "Ковельська", Area = 10, Rooms = 2, Floor = 9, Price = 1500000, Address = "вул. Ковельська, 12" });
        propertyService.AddProperty(new Apartment { Id = 2, District = "Володимира Великого", Area = 15, Rooms = 3, Floor = 7, Price = 2000000, Address = "вул. Володимира Великого, 1" });
        propertyService.AddProperty(new Apartment { Id = 3, District = "Волі", Area = 20, Rooms = 4, Floor = 3, Price = 800000, Address = "вул. Волі, 10" });

        clientService.AddClientRequest(new ClientRequest { Id = 1, FullName = "Каріна Зубко", RequestType = "купівля", Address = "вул. Ковельська, 12", PhoneNumber = "0661234567", RequestDate = DateTime.Now });
        clientService.AddClientRequest(new ClientRequest { Id = 2, FullName = "Андрій Зубко", RequestType = "обмін", Address = "вул. Володимира Великого, 1", PhoneNumber = "0671234567", RequestDate = DateTime.Now });
        clientService.AddClientRequest(new ClientRequest { Id = 3, FullName = "Аліна Зубко", RequestType = "продаж", Address = "вул. Волі, 10", PhoneNumber = "0681234567", RequestDate = DateTime.Now });

        // Цикл для обробки вводу користувача
        while (true){
            Console.WriteLine("Виберіть операцію:");
            Console.WriteLine("1. Переглянути всі заявки");
            Console.WriteLine("2. Пошук клієнта за прізвищем");
            Console.WriteLine("3. Пошук клієнта за номером телефона");
            Console.WriteLine("4. Додати заявку клієнта");
            Console.WriteLine("5. Видалити заявку клієнта");
            Console.WriteLine("0. Вихід");

            string input = Console.ReadLine();

            switch (input){
                case "1":
                    Console.WriteLine("Всі заявки:");
                    foreach (var request in clientService.GetAllClientRequests())
                    {
                        Console.WriteLine($"ID: {request.Id}, ПІБ: {request.FullName}, Тип заявки: {request.RequestType}, Адреса: {request.Address}, Телефон: {request.PhoneNumber}, Дата заявки: {request.RequestDate}");
                    }
                    break;

                case "2":
                    Console.WriteLine("Введіть прізвище клієнта:");
                    string surname = Console.ReadLine();
                    var clientBySurname = clientService.GetClientBySurname(surname);
                    if (clientBySurname != null)
                    {
                        Console.WriteLine($"ID: {clientBySurname.Id}, ПІБ: {clientBySurname.FullName}, Тип заявки: {clientBySurname.RequestType}, Адреса: {clientBySurname.Address}, Телефон: {clientBySurname.PhoneNumber}, Дата заявки: {clientBySurname.RequestDate}");
                    }
                    else
                    {
                        Console.WriteLine("Клієнта з таким прізвищем не знайдено.");
                    }
                    break;

                case "3":
                    Console.WriteLine("Введіть номер телефона клієнта:");
                    string phoneNumber = Console.ReadLine();
                    var clientByPhone = clientService.GetClientByPhoneNumber(phoneNumber);
                    if (clientByPhone != null)
                    {
                        Console.WriteLine($"ID: {clientByPhone.Id}, ПІБ: {clientByPhone.FullName}, Тип заявки: {clientByPhone.RequestType}, Адреса: {clientByPhone.Address}, Телефон: {clientByPhone.PhoneNumber}, Дата заявки: {clientByPhone.RequestDate}");
                    }
                    else
                    {
                        Console.WriteLine("Клієнта з таким номером телефона не знайдено.");
                    }
                    break;

                case "4":
                    Console.WriteLine("Введіть дані для нової заявки клієнта (ПІБ, тип заявки, адреса, номер телефона):");
                    string[] requestData = Console.ReadLine().Split(",");
                    clientService.AddClientRequest(new ClientRequest { Id = clientService.GetAllClientRequests().Count() + 1, FullName = requestData[0].Trim(), RequestType = requestData[1].Trim(), Address = requestData[2].Trim(), PhoneNumber = requestData[3].Trim(), RequestDate = DateTime.Now });
                    Console.WriteLine("Заявка клієнта додана.");
                    break;

                case "5":
                    Console.WriteLine("Введіть ID заявки клієнта, яку потрібно видалити:");
                    int requestId = int.Parse(Console.ReadLine());
                    clientService.RemoveClientRequest(requestId);
                    Console.WriteLine("Заявка клієнта видалена.");
                    break;

                case "0":
                    Console.WriteLine("До побачення!");
                    return;

                default:
                    Console.WriteLine("Невідома операція, спробуйте ще раз.");
                    break;
            }
            Console.WriteLine();
        }
    }
}
