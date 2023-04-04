using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HomeWork15.Entities
{
    public class Products
    {
        [Key]                               // Set Primary Key
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]                    // NvarChar(200)
        public string Name { get; set; }

        public decimal Price { get; set; }

        public float Discount { get; set; }

        public int? CategoryId { get; set; }

        public int Quantity { get; set; }

        public bool IsInStock { get; set; }

        public Categories Category { get; set; } // Navigation property
        public ICollection<Shops> Shops { get; set; } // Navigation property

    }
}
