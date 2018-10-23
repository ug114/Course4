using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace AdoNet
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                //Console.WriteLine("Connection state = " + connection.State);

                var sql = "SELECT COUNT(*) FROM Items";
                using (var command = new SqlCommand(sql, connection))
                {
                    var itemsCount = (int) command.ExecuteScalar();
                    Console.WriteLine("Число товаров = " + itemsCount);
                }

                sql = "INSERT INTO Categories(Name) VALUES(N'Сухофрукты')";
                using (var command = new SqlCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }

                sql = "INSERT INTO Items(Name, CategoryId) VALUES(N'Лимоны', 5)";
                using (var command = new SqlCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }

                sql = "UPDATE Items SET [Name] = N'Апельсины' WHERE [Id] = 1";
                using (var command = new SqlCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }

                sql = "DELETE FROM Items WHERE [Name] = N'Апельсины'";
                using (var command = new SqlCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }

                sql = "SELECT Items.Id, Items.Name, Categories.Name as CategoryName FROM Items INNER JOIN Categories ON Items.CategoryId = Categories.Id";
                using (var command = new SqlCommand(sql, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        Console.WriteLine("Using reader:");

                        while (reader.Read())
                        {
                            Console.WriteLine("{0} {1} {2}", reader[0], reader[1], reader[2]);
                        }

                        Console.WriteLine();
                    }
                }
                
                var items = new SqlDataAdapter(sql, connection);
                var dataSet = new DataSet("Items");
                items.FillSchema(dataSet, SchemaType.Source, "Items");
                items.Fill(dataSet, "Items");

                var tableItems = dataSet.Tables["Items"];

                Console.WriteLine("Using SqlDataAdapter:");

                foreach (DataRow drCurrent in tableItems.Rows)
                {
                    Console.WriteLine("{0} {1} {2}",
                    drCurrent["Id"],
                    drCurrent["Name"],
                    drCurrent["CategoryName"]);
                }
            }
        }
    }
}
