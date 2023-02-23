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
            Console.WriteLine("Вiзи:");
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
                FullName = "Iван Чаїв",
                PassportNumber = "AA123456",
                DateOfBirth = new DateTime(1980, 1, 1),
                Nationality = "Українець",
                IssuingAuthority = "Паспортний стiл",
                DateOfIssue = new DateTime(2020, 1, 1),
                DateOfExpiration = new DateTime(2030, 1, 1),
            };

            // Додаємо візи
            passport.AddVisa(new Visa { Country = "США", Type = "Турист", Validity = "Дiйсна до 2025" });
            passport.AddVisa(new Visa { Country = "Францiя", Type = "Студент", Validity = "Дiйсна до 2024" });

            // Виводимо інформацію про закордонний паспорт та візи
            Console.WriteLine("Iнформацiя про закордонний паспорт:");
            Console.WriteLine($"Повне iм'я: {passport.FullName}");
            Console.WriteLine($"Номер паспорту: {passport.PassportNumber}");
            Console.WriteLine($"Дата народження: {passport.DateOfBirth.ToString("dd.MM.yyyy")}");
            Console.WriteLine($"Нацiональнiсть: {passport.Nationality}");
            Console.WriteLine($"Орган який видав документ: {passport.IssuingAuthority}");
            Console.WriteLine($"Дата випуску: {passport.DateOfIssue.ToString("dd.MM.yyyy")}");
            Console.WriteLine($"Дата закiнчення: {passport.DateOfExpiration.ToString("dd.MM.yyyy")}");
            passport.DisplayVisas();


        }
    }
}