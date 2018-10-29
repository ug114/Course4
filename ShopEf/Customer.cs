using System.ComponentModel.DataAnnotations;

namespace ShopEf
{
    public class Customer
    {
        [Key]
        public string Fio { get; set; }

        [Required]
        public int Phone { get; set; }
        public string Email { get; set; }
    }
}
