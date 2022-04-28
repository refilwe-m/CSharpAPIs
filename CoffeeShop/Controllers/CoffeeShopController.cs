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
        public static int CountAllOrders()
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

        [HttpPost]
        public static string AddCustomer([FromBody] Customer customer)
        {
            var postedCustomer = customer;
            CoffeeShopQuery.RunQuery($"INSERT INTO Customers(FirstName,LastName,Birthday,BirthMonth,Race,Email) VALUES('{customer.FirstName}', '{customer.LastName}', '{customer.BirthDay}', '{customer.BirthMonth}', '{customer.Race}','{customer.Email}')");
            return "Customer Added";
        }

        [HttpPost]
        public static string AddBarista([FromBody] Barista barista)
        {
            var postedBarista = barista;
            CoffeeShopQuery.RunQuery($"INSERT INTO Baristas(FirstName,LastName,Birthday,Email,Phone) VALUES( '{barista.FirstName}', '{barista.LastName}', '{barista.Rating}')");
            return "Barista Added";
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

    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthDay { get; set; }
        public string BirthMonth { get; set; }
        public string Race { get; set; }
        public string Email { get; set; }
    }

    public class Barista
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Rating { get; set; }

    }
}