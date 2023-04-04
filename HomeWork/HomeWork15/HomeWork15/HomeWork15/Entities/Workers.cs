using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HomeWork15.Entities
{
    public class Workers
    {
        [Key]                               // Set Primary Key
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }


        public decimal Salary { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public int PositionId { get; set; }

    

        public int ShopId { get; set; }
        public Shops Shop { get; set; } // Navigation property
        public Positions Position { get; set; } // Navigation property


    }
}
