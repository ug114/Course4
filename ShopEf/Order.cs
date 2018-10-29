using System;
using System.ComponentModel.DataAnnotations;

namespace ShopEf
{
    public class Order
    {
        public int Id { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public string CustomerName { get; set; } 

        [Required]
        public int ProductId { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
