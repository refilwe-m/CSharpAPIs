using System.Data.SqlClient;
namespace CoffeeShop.Configuration
{
    public class ConnectDB
    {
        public static SqlConnection ConnectToDB()
        {
            SqlConnection connection = new SqlConnection("Server=localhost;Database=CoffeeShopDB;Trusted_Connection=True;");
            connection.Open();
            Console.WriteLine($"***{connection.Database} Successfully Opened***");
            
            return connection;
        }

    }
}