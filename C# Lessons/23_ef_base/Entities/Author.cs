namespace _23_ef_base.Entities
{
    // ...
    // Relationship with Book: One to Many (1...*)
    // ...
    class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CountryId { get; set; }

        // navigation properties
        public Country Country { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
