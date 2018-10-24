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
                
                db.SaveChanges();

                var category = db.Categories.FirstOrDefault(c => c.Id == 1);
                Console.WriteLine(category.Name);
            }
        }
    }
}
