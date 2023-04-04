using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HomeWork15.Entities
{
    public class Cities
    {
        [Key]                               // Set Primary Key
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]                    // NvarChar(200)
        public string Name { get; set; }

        public int CountryId { get; set; }
        public Countries Country { get; set; } // Navigation property
        public ICollection<Shops> Shops { get; set; } // Navigation property

    }
}
