using System.Data.SqlClient;
namespace CoffeeShop.Configuration
{
    public class ConnectDB
    {
        public static SqlConnection ConnectToDB()
        {
            var connection = new SqlConnection("Server=localhost;Database=CoffeeShopDB;Trusted_Connection=True;");
            connection.Open();
            Console.WriteLine($"***\n{connection.Database} Successfully Opened\n***");
            return connection;
        }

    }
}