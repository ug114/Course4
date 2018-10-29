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
                db.Categories.Add(new Category { Name = "������" });
                db.Categories.Add(new Category { Name = "�����" });

                db.Products.Add(new Product { Name = "���������", CategoryId = 1 });
                db.Products.Add(new Product { Name = "���������", CategoryId = 2 });

                db.Customers.Add(new Customer
                {
                    Fio = "������ ���� ����������",
                    Phone = 564322,
                    Email = "petrov@bk.ru"
                });
                db.Customers.Add(new Customer
                {
                    Fio = "�������� ������ ��������",
                    Phone = 334250,
                    Email = "kuz@mail.ru"
                });

                db.Orders.Add(new Order
                {
                    Date = new DateTime(2018, 10, 20),
                    CustomerName = "������ ���� ����������",
                    ProductId = 1
                });
                db.Orders.Add(new Order
                {
                    Date = new DateTime(2018, 10, 15),
                    CustomerName = "�������� ������ ��������",
                    ProductId = 2
                });

                db.SaveChanges();

                //var category = db.Categories.FirstOrDefault(c => c.Id == 1);
                //Console.WriteLine(category.Name);
            }
        }
    }
}
