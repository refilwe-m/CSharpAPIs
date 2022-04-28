using Microsoft.AspNetCore.Mvc;
using CoffeeShop.Models;

namespace CoffeeShop.Controllers
{
    [Produces("application/json")]
    [ApiController]
    //[Route("api/[controller]/[action]")]
    public class CoffeeShopController
    {
        [HttpGet]
        public static string GetAllOrders()
        {
            return CoffeeShopQuery.GetAllData("Orders");
        }

        [HttpGet]
        public static string GetAllCustomers()
        {
            return CoffeeShopQuery.GetAllData("Customers");
        }

        [HttpGet]
        public static string GetAllBaristas()
        {
            return CoffeeShopQuery.GetAllData("Baristas");
        }

        [HttpGet]
        public static int CountAllAfricans()
        {
            CoffeeShopQuery.CountAllAfricans();
             return int.Parse(CoffeeShopQuery.sqlResult);
        }

        [HttpGet]
        public static  int CountAllOrders()
        {
            CoffeeShopQuery.CountAllOrders();
            return int.Parse(CoffeeShopQuery.sqlResult);
        }

        [HttpGet]
        public static int CountAllCoustomers()
        {
            CoffeeShopQuery.CountAllCustomers();
            return int.Parse(CoffeeShopQuery.sqlResult);
        }

        [HttpGet]
        public static int CountAllBaristas()
        {
            CoffeeShopQuery.CountAllBaristas();
            return int.Parse(CoffeeShopQuery.sqlResult);
        }

        [HttpGet]
        public static int CountAllBirthdays(int month)
        {
            CoffeeShopQuery.CountAllBirthdays(month);
            return int.Parse(CoffeeShopQuery.sqlResult);
        }
        
        [HttpPost]
        public static string AddOrder([FromBody] Order order)
        {
            var postedOrder = order;
            //Console.WriteLine(postedOrder.CoffeeName);
            CoffeeShopQuery.RunQuery($"INSERT INTO Orders(OrderedBy,CoffeeName,Quantity,CoffeePrice,OrderAssignee) VALUES('{order.CustomerID}', '{order.CoffeeName}', {order.Quantity}, {order.Price}, '{order.BaristaID}')");
            return "Order Added";
        }

        [HttpDelete("{id}")]
        public static string DeleteOrder(int id)
        {
            CoffeeShopQuery.RunQuery($"DELETE FROM Orders WHERE OrderID = {id}");
            return "Order Deleted";
        }

        //return command.ExecuteReader();
        /*  string res = "";
         var reader = command.ExecuteReader();
         while (reader.Read())
         {
             res+= $"{reader["OrderID"]}  {reader["CoffeeName"]}\n";
         }
         return res; */




    }
    public class Order
    {
        public int CustomerID { get; set; }

        public string CoffeeName { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public int BaristaID { get; set; }
        //public string OrderDate { get; set; }
        //public string OrderTime { get; set; }

        
    }
}