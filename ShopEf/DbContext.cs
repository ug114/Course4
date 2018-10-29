using System.Data.Entity;

namespace ShopEf
{
    public class ProductContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }

        public ProductContext() : base("DefaultConnection")
        {
        }
    }
}
