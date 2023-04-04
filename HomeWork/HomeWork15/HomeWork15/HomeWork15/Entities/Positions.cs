using System.ComponentModel.DataAnnotations;


namespace HomeWork15.Entities
{
    public class Positions
    {
        [Key]                               // Set Primary Key
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]                    // NvarChar(200)
        public string Name { get; set; }
        public ICollection<Workers> Workers { get; set; } // Navigation property
    }
}
