namespace Exercise5
{
    using System;
    using System.Collections.Generic;

    // Базовий клас Passport
    class Passport
    {
        public string FullName { get; set; }
        public string PassportNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Nationality { get; set; }
        public string IssuingAuthority { get; set; }
        public DateTime DateOfIssue { get; set; }
        public DateTime DateOfExpiration { get; set; }
    }

    // Похідний клас ForeignPassport
    class ForeignPassport : Passport
    {
        public string PassportNumber { get; set; }
        public List<Visa> Visas { get; set; }

        // Конструктор класу
        public ForeignPassport()
        {
            Visas = new List<Visa>();
        }

        // Функція для додавання візи
        public void AddVisa(Visa visa)
        {
            Visas.Add(visa);
        }

        // Функція для виводу інформації про візи
        public void DisplayVisas()
        {
            Console.WriteLine("Visas:");
            foreach (var visa in Visas)
            {
                Console.WriteLine($"- {visa.Country}, {visa.Type}, {visa.Validity}");
            }
        }
    }

    // Клас для зберігання інформації про візу
    class Visa
    {
        public string Country { get; set; }
        public string Type { get; set; }
        public string Validity { get; set; }
    }

    // Приклад використання класів
    class Program
    {
        static void Main(string[] args)
        {
            // Створюємо новий закордонний паспорт
            ForeignPassport passport = new ForeignPassport
            {
                FullName = "Ivan Ivanov",
                PassportNumber = "AA123456",
                DateOfBirth = new DateTime(1980, 1, 1),
                Nationality = "Ukrainian",
                IssuingAuthority = "Passport Office",
                DateOfIssue = new DateTime(2020, 1, 1),
                DateOfExpiration = new DateTime(2030, 1, 1),
            };

            // Додаємо візи
            passport.AddVisa(new Visa { Country = "USA", Type = "Tourist", Validity = "Valid until 2025" });
            passport.AddVisa(new Visa { Country = "France", Type = "Student", Validity = "Valid until 2024" });

            // Виводимо інформацію про закордонний паспорт та візи
            Console.WriteLine("Foreign Passport Information:");
            Console.WriteLine($"Full Name: {passport.FullName}");
            Console.WriteLine($"Passport Number: {passport.PassportNumber}");
            Console.WriteLine($"Date of Birth: {passport.DateOfBirth.ToString("dd.MM.yyyy")}");
            Console.WriteLine($"Nationality: {passport.Nationality}");
            Console.WriteLine($"Issuing Authority: {passport.IssuingAuthority}");
            Console.WriteLine($"Date of Issue: {passport.DateOfIssue.ToString("dd.MM.yyyy")}");
            Console.WriteLine($"Date of Expiration: {passport.DateOfExpiration.ToString("dd.MM.yyyy")}");
            passport.DisplayVisas();

    
        }
    }
}