using System.ComponentModel.DataAnnotations;
namespace HomeWork15.Entities
{

    public class Countries
    {
        [Key]                               // Set Primary Key
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]                    // NvarChar(200)
        public string Name { get; set; }
        public ICollection<Cities> Cities { get; set; } // Navigation property
        public ICollection<Workers> Workers { get; set; } // Navigation property for Workers
    }

}
