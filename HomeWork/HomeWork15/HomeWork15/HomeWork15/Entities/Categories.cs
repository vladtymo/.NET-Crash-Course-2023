using System.ComponentModel.DataAnnotations;


namespace HomeWork15.Entities
{
    public class Categories
    {
        [Key]                               // Set Primary Key
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]                    // NvarChar(200)
        public string Name { get; set; }
        public ICollection<Products> Products { get; set; } // Navigation property
    }
}
