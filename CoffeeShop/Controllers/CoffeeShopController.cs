using Microsoft.AspNetCore.Mvc;
using CoffeeShop.Models;
//using CoffeeShop.Configuration;
namespace CoffeeShop.Controllers
{
    //[ApiController]
    //[Route("api")]
    public class CoffeeShopController
    {
        [HttpGet("[GetAllOrders]")]
        public static string GetAllOrders()
        {
            return CoffeeShopQuery.GetAllData("Orders");
        }

        [HttpGet("[GetAllCustomers]")]
        public static string GetAllCustomers()
        {
            return CoffeeShopQuery.GetAllData("Customers");
        }

        [HttpGet("[GetAllBaristas]")]
        public static string GetAllBaristas()
        {
            return CoffeeShopQuery.GetAllData("Baristas");
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
}