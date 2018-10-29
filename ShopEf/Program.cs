using System;
using System.Linq;

namespace ShopEf
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using (var db = new ProductContext())
            {
                db.Categories.Add(new Category { Name = "Фрукты" });
                db.Categories.Add(new Category { Name = "Овощи" });

                db.Products.Add(new Product { Name = "Апельсины", CategoryId = 1 });
                db.Products.Add(new Product { Name = "Картофель", CategoryId = 2 });

                db.Customers.Add(new Customer
                {
                    Fio = "Петров Иван Михайлович",
                    Phone = 564322,
                    Email = "petrov@bk.ru"
                });
                db.Customers.Add(new Customer
                {
                    Fio = "Кузнецов Михаил Иванович",
                    Phone = 334250,
                    Email = "kuz@mail.ru"
                });

                db.Orders.Add(new Order
                {
                    Date = new DateTime(2018, 10, 20),
                    CustomerName = "Петров Иван Михайлович",
                    ProductId = 1
                });
                db.Orders.Add(new Order
                {
                    Date = new DateTime(2018, 10, 15),
                    CustomerName = "Кузнецов Михаил Иванович",
                    ProductId = 2
                });

                db.SaveChanges();

                //var category = db.Categories.FirstOrDefault(c => c.Id == 1);
                //Console.WriteLine(category.Name);
            }
        }
    }
}
