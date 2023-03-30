namespace _23_ef_base.Entities
{
    class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // navigation properties
        public ICollection<Author> Authors { get; set; }
    }
}
