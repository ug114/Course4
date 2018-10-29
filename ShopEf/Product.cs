using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopEf
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        //[ForeignKey("CategoryId")]
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
