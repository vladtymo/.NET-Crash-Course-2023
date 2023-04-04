using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace HomeWork15.Entities
{
    public class Shops
    {
        [Key]                               // Set Primary Key
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]                    // NvarChar(200)
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]                    // NvarChar(200)
        public string Address { get; set; }

        public int CityId { get; set; }


        public int? PartingArea { get; set; }


        public Cities City { get; set; } // Navigation property
        public ICollection<Workers> Workers { get; set; } // Navigation property
        public ICollection<Products> Products { get; set; } // Navigation property


    }
}
