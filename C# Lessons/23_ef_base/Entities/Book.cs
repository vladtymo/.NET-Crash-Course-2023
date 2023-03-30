using System.ComponentModel.DataAnnotations;

namespace _23_ef_base.Entities
{
    class Book
    {
        // properties (columns)
        [Key]                               // Set Primary Key
        public int Id { get; set; }         // Primary Key: Id/ID/id EntityName+Id
        [Required]
        [MaxLength(200)]                    // NvarChar(200)
        public string Title { get; set; }
        public int Pages { get; set; }
        public decimal Price { get; set; }
        public float Rating { get; set; }
        public int AuthorId { get; set; }   // Foreign Key: RelateEntity+PrimaryKeyName

        // navigation properties - reference to an another column
        public Author Author { get; set; }
    }
}
