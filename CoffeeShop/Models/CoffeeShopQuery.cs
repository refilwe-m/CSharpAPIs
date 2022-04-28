using System.Data.SqlClient;
using CoffeeShop.Configuration;
using CoffeeShop.Controllers;

namespace CoffeeShop.Models
{
    public class CoffeeShopQuery
    {
        public static Dictionary<string, string> queries = new Dictionary<string, string>(){
    {"Select", "SELECT * FROM "},

};
        public static string sqlResult = "";

        public static void RunQuery(string query)
        {
            var connection = ConnectDB.ConnectToDB();
            try
            {
                var reader = new SqlCommand(query, connection).ExecuteReader();
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        sqlResult += $"{reader[i]} ";
                    }
                    //Console.WriteLine(reader.FieldCount);
                    sqlResult += "\n";
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (sqlResult == "")
                {
                    sqlResult = "Query Completed";
                }
                connection.Close();
                Console.WriteLine("Connection Closed");
            }


        }
        public static string GetAllData(String tableName)
        {
            Console.WriteLine(sqlResult);
            RunQuery($"{queries["Select"]}{tableName}");
            return sqlResult;
        }

        public static void AddOrder(Order order)
        {
            RunQuery($"INSERT INTO Orders VALUES('{order.CustomerID}', '{order.CoffeeName}', {order.Quantity}, {order.CoffeePrice}, '{order.BaristaID}')");
        }

        //insert customer
        public static void AddCustomer(Customer customer)
        {
            RunQuery($"INSERT INTO Customers VALUES('{customer.FirstName}', '{customer.LastName}', '{customer.BirthDay}', '{customer.BirthMonth}','{customer.Race}', '{customer.Email}')");
        }

        //insert barista
        public static void AddBarista(Barista barista)
        {
            RunQuery($"INSERT INTO Baristas VALUES(''{barista.FirstName}', '{barista.LastName}', '{barista.Rating}')");
        }

        public static void DeleteOrder(int id)
        {
            RunQuery($"DELETE FROM Orders WHERE OrderID = {id}");
        }

        public static void DeleteCustomer(int id)
        {
            RunQuery($"DELETE FROM Customers WHERE CustomerID = {id}");
        }

        public static void DeleteBarista(int id)
        {
            RunQuery($"DELETE FROM Baristas WHERE BaristaID = {id}");
        }

        public static void CountAllOrders()
        {
            RunQuery($"SELECT COUNT(*) FROM Orders");        
        }

        public static void CountAllCustomers()
        {
            RunQuery($"SELECT COUNT(*) FROM Customers");
           
        }

        public static void CountAllBaristas()
        {
            RunQuery($"SELECT COUNT(*) FROM Baristas");
        }

        public static void CountAllAfricans()
        {
            RunQuery($"SELECT COUNT(*) FROM Customers WHERE Race = 'Black'");  
        }

        public static void CountAllBirthdays(int month)
        {
            RunQuery($"SELECT COUNT(*) FROM Customers WHERE MMOB = {month}");
            
        }

        //updateOrder
        public static void UpdateOrder(Order order,int id)
        {
            RunQuery($"UPDATE Orders SET CoffeeName = '{order.CoffeeName}', Quantity = {order.Quantity}, CoffeePrice = {order.CoffeePrice}, BaristaID = '{order.BaristaID}' WHERE OrderID = {id}");
        }

        /* public static string GetUpdate(String tableName)
        {
            string query = "SELECT * FROM " + tableName;
            return query;
        } */

    }
}