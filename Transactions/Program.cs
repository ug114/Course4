using System.Data.SqlClient;
using System.Configuration;
using System;

namespace Transactions
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var transaction = connection.BeginTransaction();
                try
                {
                    const string sql = "INSERT INTO Categories(Name) VALUES(N'Орехи')";
                    var command = new SqlCommand(sql, connection) {Transaction = transaction};
                    command.ExecuteNonQuery();
                    
                    if (sql.Contains("Орехи"))
                    {
                        throw new Exception("Транзакция отменена.");
                    }

                    transaction.Commit();
                }
                catch (Exception e)
                {
                    transaction.Rollback(); 
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
