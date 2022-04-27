using System.Data.SqlClient;
using CoffeeShop.Configuration;
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
                    for(int i = 0; i < reader.FieldCount; i++)
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

        /* public static string GetUpdate(String tableName)
        {
            string query = "SELECT * FROM " + tableName;
            return query;
        } */

    }
}